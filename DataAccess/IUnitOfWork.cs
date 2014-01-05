//-----------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="Stephen Jennings">
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
    using WcfDataServicesClientSample.Repositories;

    /// <summary>
    /// Provides access to data repositories and allows
    /// updating one or many as a single transaction.
    /// </summary>
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        /// <summary>
        /// Saves all changes that have been made to entities retrieved from the repositories.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Indicates that the entity should be updated when SaveChanges is called.
        /// </summary>
        /// <param name="entity">The entity to be updated.</param>
        void UpdateObject(object entity);
    }
}
