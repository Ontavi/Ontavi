// <copyright file="SchemaFieldAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;

    /// <summary>
    /// Denotes that a property on a class inheriting from <see cref="Schema"/> is a field.
    /// Defines the type of field and any special flags.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SchemaFieldAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaFieldAttribute"/> class with the 
        /// specified type and field flags.
        /// </summary>
        /// <param name="fieldType">The type of the field.</param>
        /// <param name="fieldFlags">Any special flags to apply to the field.</param>
        public SchemaFieldAttribute(FieldType fieldType, FieldFlags fieldFlags = FieldFlags.None)
        {

        }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        public FieldType FieldType { get; private set; }

        /// <summary>
        /// Gets the special flags applied to the field.
        /// </summary>
        public FieldFlags FieldFlags { get; private set; }
    }
}
