// <copyright file="MiddlewareInputAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    /// <summary>
    /// Denotes that a field on a <see cref="Middleware"/> instance is input to the middleware.
    /// </summary>
    public class MiddlewareInputAttribute : PropertyDescriptorAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiddlewareInputAttribute"/> class with the specified
        /// identifier and optional description of the purpose of the input.
        /// </summary>
        /// <param name="id">The identifier of the field; used in YAML files to write values to the input.</param>
        /// <param name="fieldType">The underlying type of data in the field.</param>
        /// <param name="fieldFlags">Special flags that modify the field (e.g. array, nullable).</param>
        /// <param name="description">
        /// An optional, brief description of the input. Used by Studio to describe the input's purpose
        /// to the author of the pipeline.
        /// </param>
        public MiddlewareInputAttribute(string id, FieldType fieldType, FieldFlags fieldFlags = FieldFlags.None, string description = null)
            : base(id, description)
        {
        }

        /// <summary>
        /// Gets the underlying type of data in the field.
        /// </summary>
        public FieldType FieldType { get; private set; }

        /// <summary>
        /// Gets the flags on the underlying field that modify the field (e.g. array, nullable).
        /// </summary>
        public FieldFlags FieldFlags { get; private set; }
    }
}
