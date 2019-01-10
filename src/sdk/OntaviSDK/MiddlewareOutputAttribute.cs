// <copyright file="MiddlewareOutputAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;

    /// <summary>
    /// Denotes that a field on a <see cref="Middleware"/> instance is output from the middleware.
    /// </summary>
    public class MiddlewareOutputAttribute : PropertyDescriptorAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewareOutputAttribute "/> class with the specified
        /// identifier and optional description of the purpose of the output.
        /// </summary>
        /// <param name="id">The identifier of the field; used in YAML files to read values from the output.</param>
        /// <param name="description">
        /// An optional, brief description of the output. Used by Studio to describe the output's purpose
        /// to the author of the pipeline.
        /// </param>
        public MiddlewareOutputAttribute(string id, string description = null)
            : base(id, description)
        {
        }
    }
}
