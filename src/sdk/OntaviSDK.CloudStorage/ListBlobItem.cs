// <copyright file="ListBlobItem.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

using System;

namespace OntaviSDK.CloudStorage
{
    /// <summary>
    /// Defines the schema for an item in the output of a <see cref="ListBlobsMiddleware"/>
    /// middleware execution.
    /// </summary>
    public class ListBlobItem : Schema
    {
        /// <summary>
        /// Gets or sets the name of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Url location of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the MIME content type of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the MD5 hash of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string ContentMD5 { get; set; }

        /// <summary>
        /// Gets or sets the content disposition of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the blob.
        /// </summary>
        [SchemaField(FieldType.Text)]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the length of the blob.
        /// </summary>
        [SchemaField(FieldType.Number)]
        public long Length { get; set; }

        /// <summary>
        /// Gets or sets the date the blob was last modified.
        /// </summary>
        [SchemaField(FieldType.DateTime)]
        public DateTimeOffset? LastModified { get; set; }
    }
}
