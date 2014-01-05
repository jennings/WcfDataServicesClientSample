//-----------------------------------------------------------------------
// <copyright file="UpdateTests.cs" company="Stephen Jennings">
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
    public class UpdateTests
    {
        private IUnitOfWork uow;

        [SetUp]
        public void SetUp()
        {
            this.uow = UnitOfWorkBuilder.Build(ENDPOINTS.READWRITE_URI);
        }

        [Test]
        public void CanUpdateOneProperty()
        {
            var id = 5;

            // Perform the update
            var product = uow.Products.Queryable.Where(p => p.ID == id).First();
            var newPrice = product.Price + 1.0;
            product.Price = newPrice;
            uow.UpdateObject(product);
            uow.SaveChanges();

            SetUp(); // Create a new UnitOfWork

            // Verify it was saved
            var newProduct = uow.Products.Queryable.Where(p => p.ID == id).First();
            Assert.AreEqual(newPrice, newProduct.Price, 0.001);
        }

        [Test]
        public void CanUpdatePropertiesOnRelatedEntities()
        {
            var id = 5;
            var newDetails = Guid.NewGuid().ToString();

            var product = uow.Products.QueryableWithDetails.Where(p => p.ID == id).First();
            product.ProductDetail.Details = newDetails;
            uow.UpdateObject(product);
            uow.SaveChanges();

            SetUp(); // Create a new UnitOfWork

            var newProduct = uow.Products.QueryableWithDetails.Where(p => p.ID == id).First();
            Assert.AreEqual(newDetails, newProduct.ProductDetail.Details);
        }
    }
}
