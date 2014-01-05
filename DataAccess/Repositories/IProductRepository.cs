//-----------------------------------------------------------------------
// <copyright file="IProductRepository.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WcfDataServicesClientSample.Models;

    /// <summary>
    /// A source of stored Products.
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> QueryableWithDetails { get; }
    }
}
