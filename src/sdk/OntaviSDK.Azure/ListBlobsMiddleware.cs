// <copyright file="ListBlobsMiddleware.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.Azure
{
    using System.Threading.Tasks;
    using TwentyTwenty.Storage.Azure;

    /// <summary>
    /// Gets a list of blobs from Azure storage.
    /// </summary>
    public class ListBlobsMiddleware : Middleware
    {
        /// <summary>
        /// Gets or sets the <see cref="AzureBlobStorageEndpoint"/> from which to list blobs.
        /// </summary>
        [MiddlewareEndpoint("storage", "Provide the endpoint from which to list blobs.")]
        public AzureBlobStorageEndpoint StorageEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the name of the container from which to get a list of blobs.
        /// </summary>
        [MiddlewareInput("containerName", FieldType.Text, FieldFlags.Required, "The name of the container.")]
        public PersistedObject ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the list of files in blob storage.
        /// </summary>
        [MiddlewareOutput("list", "The list of files in blob storage.")]
        public PersistedObject List { get; set; }

        /// <inheritdoc/>
        public async override Task ExecuteAsync(MiddlewareExecutionContext context)
        {
            var storageProvider = new AzureStorageProvider(new AzureProviderOptions()
            {
                ConnectionString = this.StorageEndpoint.ConnectionString
            });

            var blobs = await storageProvider.ListBlobsAsync(await this.ContainerName.GetTextAsync());

            // TODO: Handle output
        }
    }
}
