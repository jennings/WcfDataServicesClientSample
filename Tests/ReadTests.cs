//-----------------------------------------------------------------------
// <copyright file="ReadTests.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Data.Services.Client;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    public class ReadTests
    {
        private IUnitOfWork uow;

        [SetUp]
        public void SetUp()
        {
            this.uow = UnitOfWorkBuilder.Build(ENDPOINTS.READONLY_URI);
        }

        [Test(Description = "Verifies the UnitOfWork can be constructed.")]
        public void CanBeConstructed()
        {
            Assert.Pass();
        }

        [Test(Description = "Verifies that we can call an IQueryable interface on the ProductRepository.")]
        public void CanQueryASingleEntity()
        {
            var query = uow.Products.Queryable.Take(1);
        }

        [Test(Description = "Verifies that we can materialize the IQueryable into a concrete object.")]
        public void CanMaterializeAQuery()
        {
            var materialized = uow.Products.Queryable.First();
        }

        [Test(Description = "Verifies that when we materialize an entity, the ID property is set properly.")]
        public void MaterializationSetsTheID()
        {
            var materialized = uow.Products.Queryable.Where(p => p.ID != 0).First();
            Assert.AreNotEqual(0, materialized.ID);
        }

        [Test(Description = "Verifies that multiple items can be returned from a query")]
        public void CanQueryAResultSetWithMultipleItems()
        {
            var result = uow.Products.Queryable.Take(3).ToList();
            Assert.AreEqual(3, result.Count);
        }

        [Test(Description = "Verifies that non-key properties are returned from a query")]
        public void MaterializationSetsThePrice()
        {
            var result = uow.Products.Queryable.Where(p => p.Rating == 3).First();
            Assert.AreNotEqual(0.0, result.Price);
        }
    }
}
