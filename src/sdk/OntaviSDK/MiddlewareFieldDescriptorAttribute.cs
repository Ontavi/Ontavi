// <copyright file="MiddlewareFieldDescriptorAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;

    /// <summary>
    /// Describes a field on a <see cref="Middleware"/> instance with metadata used by the engine and Studio.
    /// </summary>
    public class MiddlewareFieldDescriptorAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewareFieldDescriptorAttribute"/> class with the specified
        /// identifier, name, and optional description of the purpose of the input.
        /// </summary>
        /// <param name="id">The identifier of the field; used in YAML files to read/write values to the field.</param>
        /// <param name="description">
        /// An optional, brief description of the field. Used by Studio to describe the input's purpose
        /// to the author of the pipeline.
        /// </param>
        public MiddlewareFieldDescriptorAttribute(string id, string description = null)
        {
            this.Id = id;
            this.Description = description;
        }

        /// <summary>
        /// Gets the identifier of the field.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a description of the field.
        /// </summary>
        public string Description { get; private set; }
    }
}
