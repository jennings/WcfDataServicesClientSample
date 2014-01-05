//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Stephen Jennings">
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

    /// <summary>
    /// A source of stored entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity provided by this repository.</typeparam>
    public interface IRepository<TEntity> where TEntity : new()
    {
        IQueryable<TEntity> Queryable { get; }
    }
}
