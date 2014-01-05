//-----------------------------------------------------------------------
// <copyright file="UnitOfWork.cs" company="Stephen Jennings">
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
    /// Provides data access and atomic transactions to a WCF Data Services (OData) connection.
    /// </summary>
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DataServiceContext context;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="context">The entity source for repositories in this instance.</param>
        public UnitOfWork(DataServiceContext context)
        {
            this.context = context;

            this.Products = new ProductRepository(context);
        }

        public IProductRepository Products { get; private set; }

        /// <summary>
        /// Saves all changes that have been made to entities retrieved from the repositories.
        /// </summary>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
