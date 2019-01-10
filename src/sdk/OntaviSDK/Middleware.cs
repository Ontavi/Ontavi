// <copyright file="Middleware.cs" company="Ontavi LLC">
// Copyright (c) Ontavi LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// </copyright>

namespace OntaviSDK
{
    using System.Threading.Tasks;

    /// <summary>
    /// A step in a [[Pipeline]] that can transform, manipulate, or enrich data.
    /// </summary>
    public abstract class Middleware
    {
        /// <summary>
        /// Gets the name of this instance of middleware in the pipeline.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Executes the workload of the <see cref="Middleware" />.
        /// </summary>
        /// <param name="context">
        /// The context under which this middleware instance is executing. Provides access to the inputs,
        /// outputs, and other properties defined in the middleware. Also exposes common services to the
        /// middleware (such as logging).
        /// </param>
        /// <returns>Returns a <c>Task</c> with the middleware workload.</returns>
        public abstract Task ExecuteAsync(MiddlewareExecutionContext context);
    }
}
