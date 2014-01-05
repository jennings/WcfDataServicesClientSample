//-----------------------------------------------------------------------
// <copyright file="ProductRepository.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Services.Client;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WcfDataServicesClientSample.Models;

    /// <summary>
    /// A repository of Products backed by WCF Data Services.
    /// </summary>
    /// <remarks>
    /// Note that this class is INTERNAL because external users should only
    /// be aware of the interface <see cref="IProductRepository"/>.
    /// </remarks>
    internal class ProductRepository : IProductRepository
    {
        private const string ENTITY_NAME = "Products";

        private readonly DataServiceContext context;

        public ProductRepository(DataServiceContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> Queryable
        {
            get
            {
                // When someone queries, we ferry it to the DataServiceContext
                return this.context.CreateQuery<Product>(ENTITY_NAME);
            }
        }
    }
}
