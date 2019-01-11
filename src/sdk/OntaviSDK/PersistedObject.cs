// <copyright file="PersistedObject.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Syroot.BinaryData;

    public class PersistedObject
    {
        private readonly BinaryStream binaryStream;
        private long totalTextSize;
        private long textReadSoFar;
        private bool isReadingChunk;
        private bool hasReadEndOfChunk;

        public PersistedObject(Stream baseStream)
        {
            this.binaryStream = new BinaryStream(
                baseStream: baseStream,
                converter: new ByteConverterLittle(),
                encoding: System.Text.Encoding.Unicode,
                stringCoding: StringCoding.Int32CharCount);
        }

        public Task<string> GetTextAsync()
        {
            return this.binaryStream.ReadStringAsync();
        }

        public async Task<string> GetTextChunkAsync(int maxChunkSize)
        {
            if (!this.isReadingChunk)
            {
                this.isReadingChunk = true;

                this.textReadSoFar = 0;
                this.totalTextSize = await this.binaryStream.ReadInt64Async();
            }
            else if (this.isReadingChunk && this.textReadSoFar == this.totalTextSize)
            {
                return null;
            }

            var nextChunkSize = (int)Math.Min(maxChunkSize, this.totalTextSize - this.textReadSoFar);
            var nextChunk = await this.binaryStream.ReadStringAsync();

            this.textReadSoFar += nextChunkSize;

            return nextChunk;
        }

        public Task<long> GetNumberAsync()
        {
            return this.binaryStream.ReadInt64Async();
        }

        public Task<decimal> GetDecimalAsync()
        {
            return this.binaryStream.ReadDecimalAsync();
        }

        public async Task<DateTimeOffset> GetDateAsync()
        {
            var ticks = await this.binaryStream.ReadInt64Async();
            var dateTime = new DateTimeOffset(ticks, TimeSpan.Zero);

            return dateTime.Date;
        }

        public async Task<TimeSpan> GetTimeSpanAsync()
        {
            var ticks = await this.binaryStream.ReadInt64Async();
            return new TimeSpan(ticks);
        }

        public async Task<DateTimeOffset> GetDateTimeAsync()
        {
            var ticks = await this.binaryStream.ReadInt64Async();
            return new DateTimeOffset(ticks, TimeSpan.Zero);
        }

        public Task<bool> GetBooleanAsync()
        {
            return this.binaryStream.ReadBooleanAsync();
        }

        public async Task<Guid> GetGuidAsync()
        {
            var guidData = await this.binaryStream.ReadBytesAsync(16);
            return new Guid(guidData);
        }
    }
}
