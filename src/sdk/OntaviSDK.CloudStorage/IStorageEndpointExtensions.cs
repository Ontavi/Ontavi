// <copyright file="IStorageEndpointExtensions.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK.CloudStorage
{
    using System;
    using Google.Apis.Auth.OAuth2;
    using TwentyTwenty.Storage;
    using TwentyTwenty.Storage.Amazon;
    using TwentyTwenty.Storage.Azure;
    using TwentyTwenty.Storage.Google;

    public static class IStorageEndpointExtensions
    {
        public static IStorageProvider GetStorageProvider(this IStorageEndpoint endpoint)
        {
            if (endpoint is AzureStorageEndpoint azureStorageEndpoint)
            {
                return new AzureStorageProvider(new AzureProviderOptions()
                {
                    ConnectionString = azureStorageEndpoint.ConnectionString
                });
            }
            else if (endpoint is AmazonStorageProvider)
            {
                return new AmazonStorageProvider(new AmazonProviderOptions()
                {

                });
            }
            else if (endpoint is GoogleStorageProvider)
            {
                var credential = GoogleCredential.FromJson(null);
                var options = new GoogleProviderOptions();

                return new GoogleStorageProvider(credential, options);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
