// <copyright file="ReadBlobMiddleware.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.Azure
{
    using System.Threading.Tasks;
    using TwentyTwenty.Storage.Azure;

    /// <summary>
    /// Reads a blob from Azure storage and outputs the blob content.
    /// </summary>
    public class ReadBlobMiddleware : Middleware
    {
        /// <summary>
        /// Gets or sets the <see cref="AzureBlobStorageEndpoint"/> from which the blob should be read.
        /// </summary>
        [MiddlewareEndpoint("storage", "Provide the endpoint from which to read a blob.")]
        public AzureBlobStorageEndpoint StorageEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the name of the container in which the blob resides.
        /// </summary>
        [MiddlewareInput("containerName", FieldType.Text, FieldFlags.Required, "The name of the container in which the blob resides.")]
        public PersistedObject ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the file in blob storage to read.
        /// </summary>
        [MiddlewareInput("fileName", FieldType.Text, FieldFlags.Required, "The name of the file in blob storage to read.")]
        public PersistedObject FileName { get; set; }

        /// <summary>
        /// Gets or sets the contents of the file in blob storage.
        /// </summary>
        [MiddlewareOutput("fileContents", "The contents of the file in blob storage.")]
        public PersistedObject FileContents { get; set; }

        /// <inheritdoc/>
        public async override Task ExecuteAsync(MiddlewareExecutionContext context)
        {
            var storageProvider = new AzureStorageProvider(new AzureProviderOptions()
            {
                ConnectionString = this.StorageEndpoint.ConnectionString
            });

            var blob = await storageProvider.GetBlobStreamAsync(await this.ContainerName.GetTextAsync(), await this.FileName.GetTextAsync());
            
            // TODO: Handle output
        }
    }
}
