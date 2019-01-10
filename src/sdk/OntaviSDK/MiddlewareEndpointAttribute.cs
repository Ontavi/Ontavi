// <copyright file="MiddlewareEndpointAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    /// <summary>
    /// Denotes that a field on a <see cref="Middleware"/> instance is an endpoint needed by the middleware.
    /// </summary>
    public class MiddlewareEndpointAttribute : PropertyDescriptorAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewareEndpointAttribute "/> class with the specified
        /// identifier and optional description of the purpose of the endpoint.
        /// </summary>
        /// <param name="id">
        /// The identifier of the field; used in YAML files to assign the connector to one defined in the <c>endpoints</c>
        /// section of the pipeline definition.
        /// </param>
        /// <param name="description">
        /// An optional, brief description of the connector. Used by Studio to describe the endpoint's purpose
        /// to the author of the pipeline.
        /// </param>
        public MiddlewareEndpointAttribute(string id, string description = null)
            : base(id, description)
        {
        }
    }
}
