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

            // Our models may not have every property defined on them
            this.context.IgnoreMissingProperties = true;

            // Without this, update queries send DataServiceVersion: 1.0.
            // There may be a better way of dealing with this, but
            // this is the only remedy I was able to find.
            // See: http://stackoverflow.com/a/17846697/19818
            this.context.SendingRequest2 += (sender, args) =>
            {
                args.RequestMessage.SetHeader("DataServiceVersion", "3.0;NetFx");
            };

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

        /// <summary>
        /// Indicates that the entity should be updated when SaveChanges is called.
        /// </summary>
        /// <param name="entity">The entity to be updated.</param>
        public void UpdateObject(object entity)
        {
            this.context.UpdateObject(entity);
        }
    }
}
