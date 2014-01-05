//-----------------------------------------------------------------------
// <copyright file="Product.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Product
    {
        public int ID { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public DateTimeOffset? DiscontinuedDate { get; set; }
        public short Rating { get; set; }
        public double Price { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}
