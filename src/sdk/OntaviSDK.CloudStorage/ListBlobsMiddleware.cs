// <copyright file="ListBlobsMiddleware.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.CloudStorage
{
    using System.Threading.Tasks;

    /// <summary>
    /// Gets a list of blobs from cloud storage.
    /// </summary>
    public class ListBlobsMiddleware : Middleware
    {
        /// <summary>
        /// Gets or sets the <see cref="IStorageEndpoint"/> from which to list blobs.
        /// </summary>
        [MiddlewareEndpoint("storage", "Provide the endpoint from which to list blobs.")]
        public IStorageEndpoint StorageEndpoint { get; set; }

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
            var storageProvider = this.StorageEndpoint.GetStorageProvider();
            var blobs = await storageProvider.ListBlobsAsync(await this.ContainerName.GetTextAsync());

            // TODO: Handle output
        }
    }
}
