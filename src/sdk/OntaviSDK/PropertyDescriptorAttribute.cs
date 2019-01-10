// <copyright file="PropertyDescriptorAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;

    /// <summary>
    /// Describes a property on an Ontavi object instance with metadata used by the engine and Studio.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDescriptorAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDescriptorAttribute"/> class with the specified
        /// identifier and optional description of the purpose of the input.
        /// </summary>
        /// <param name="id">The identifier of the property; used in YAML files to identify the property.</param>
        /// <param name="description">
        /// An optional, brief description of the property. Used by Studio to describe the property's purpose
        /// to the author of the pipeline.
        /// </param>
        public PropertyDescriptorAttribute(string id, string description = null)
        {
            this.Id = id;
            this.Description = description;
        }

        /// <summary>
        /// Gets the identifier of the property.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a description of the property.
        /// </summary>
        public string Description { get; private set; }
    }
}
