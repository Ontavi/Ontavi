// <copyright file="EndpointSettingAttribute.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    /// <summary>
    /// Denotes that a field on an <see cref="Endpoint"/> instance is a setting required by the endpoint.
    /// </summary>
    public class EndpointSettingAttribute : PropertyDescriptorAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSettingAttribute "/> class with the specified
        /// identifier and optional description of the purpose of the setting.
        /// </summary>
        /// <param name="id">The identifier of the setting; used in YAML files to assign the value of the setting on the <see cref="Endpoint"/>.</param>
        /// <param name="description">
        /// An optional, brief description of the setting. Used by Studio to describe the setting's purpose to the author of the pipeline.
        /// </param>
        public EndpointSettingAttribute(string id, string description = null)
            : base(id, description)
        {
        }
    }
}
