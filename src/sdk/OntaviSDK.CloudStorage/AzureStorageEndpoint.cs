// <copyright file="AzureStorageEndpoint.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.CloudStorage
{
    /// <summary>
    /// Describes an Azure Blob Storage account that <see cref="Middleware"/> in a [[Pipeline]] will consume.
    /// </summary>
    public class AzureStorageEndpoint : Endpoint, IStorageEndpoint
    {
        /// <summary>
        /// Gets or sets the Azure Storage connection string for the endpoint.
        /// </summary>
        [EndpointSetting("connectionString", "The Azure Storage connection string (e.g. DefaultEndpointsProtocol=http;AccountName=myAccount;AccountKey=myKey;)")]
        public string ConnectionString { get; set; }
    }
}
