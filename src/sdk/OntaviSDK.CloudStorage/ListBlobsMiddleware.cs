// <copyright file="ListBlobsMiddleware.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.CloudStorage
{
    using System.Collections.Generic;
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
        [MiddlewareInput("containerName", FieldType.Text, description: "The name of the container.")]
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
            var resultList = new List<ListBlobItem>();

            foreach (var blob in await storageProvider.ListBlobsAsync(await this.ContainerName.GetTextAsync()))
            {
                resultList.Add(new ListBlobItem()
                {
                    Name = blob.Name,
                    Url = blob.Url,
                    Length = blob.Length,
                    ContentType = blob.ContentType,
                    ContentDisposition = blob.ContentDisposition,
                    ContentMD5 = blob.ContentMD5,
                    ETag = blob.ETag,
                    LastModified = blob.LastModified
                });
            }

            // TODO: Handle output
        }
    }
}
