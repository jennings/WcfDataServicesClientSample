//-----------------------------------------------------------------------
// <copyright file="ENDPOINTS.cs" company="Stephen Jennings">
//     Copyright (c) Stephen Jennings 2014.
//     Licensed under the Apache License, Version 2.0.
//     http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
//-----------------------------------------------------------------------

namespace WcfDataServicesClientSample.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class ENDPOINTS
    {
        /// <summary>
        /// A read-only endpoint that allows the ReadTests fixture to pass.
        /// </summary>
        public static readonly Uri READONLY_URI = new Uri("http://services.odata.org/V3/OData/OData.svc");

        /// <summary>
        /// A read-write endpoint allowing updates.
        /// To generate your own URL for testing, visit the following URL in your browser.
        ///   http://services.odata.org/V3/(S(readwrite))/odata/odata.svc/
        /// You will be redirected to a new URL containing a unique token allowing you to
        /// write changes that will be persisted across calls.
        /// </summary>
        public static readonly Uri READWRITE_URI = new Uri("http://example.com/SEE-COMMENTS-ABOVE");
    }
}
