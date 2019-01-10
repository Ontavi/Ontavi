// <copyright file="FieldFlags.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System;

    /// <summary>
    /// Applies flags to the field that modify the behavior or enforce requirements.
    /// </summary>
    [Flags]
    public enum FieldFlags
    {
        /// <summary>
        /// No special flags on the field.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Field is an array of the underlying <see cref="FieldType"/>.
        /// </summary>
        Array = 0x1,

        /// <summary>
        /// Field is a dictionary of the underlying <see cref="FieldType"/>; <c>string</c> keys are assumed.
        /// </summary>
        Dictionary = 0x2,

        /// <summary>
        /// Field is required; a null or empty value will result in an error.
        /// </summary>
        Required = 0x4
    }
}
