//-----------------------------------------------------------------------
// <copyright file="UnitOfWorkBuilder.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample
{
    using System;
    using System.Collections.Generic;
    using System.Data.Services.Client;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A builder used in lieu of a dependency injection container.
    /// </summary>
    public static class UnitOfWorkBuilder
    {
        /// <summary>
        /// Builds a UnitOfWork.
        /// Normally, this would be handled by a dependency injection container
        /// such as Castle Windsor or the Unity Application Block.
        /// </summary>
        /// <param name="uri">The URI of the OData service.</param>
        /// <returns>A unit of work which accesses the given URI.</returns>
        public static IUnitOfWork Build(Uri uri)
        {
            var context = new DataServiceContext(uri);
            return new UnitOfWork(context);
        }
    }
}
