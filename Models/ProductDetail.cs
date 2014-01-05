//-----------------------------------------------------------------------
// <copyright file="ProductDetails.cs" company="Stephen Jennings">
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

    public sealed class ProductDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Details { get; set; }
    }
}
