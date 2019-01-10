// <copyright file="FieldType.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    /// <summary>
    /// Describes the type of data that a field contains.
    /// </summary>
    public enum FieldType
    {
        /// <summary>
        /// Field is text (string) that contains a sequence of characters.
        /// </summary>
        Text,

        /// <summary>
        /// Field is a whole number.
        /// </summary>
        Number,

        /// <summary>
        /// Field is a decimal number (floating point, etc.)
        /// </summary>
        Decimal,

        /// <summary>
        /// Field is a calendar date.
        /// </summary>
        Date,

        /// <summary>
        /// Field is a length of time.
        /// </summary>
        TimeSpan,

        /// <summary>
        /// Field is a specific time on a given calendar date.
        /// </summary>
        DateTime,

        /// <summary>
        /// Field is a boolean (<c>true</c> or <c>false</c>).
        /// </summary>
        Boolean,

        /// <summary>
        /// Field is a globally unique identifier.
        /// </summary>
        Guid,

        /// <summary>
        /// Field is a non-primitive type composed of other fields.
        /// </summary>
        Object
    }
}
