﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.ObjectModel;

namespace Microsoft.Test.E2E.AspNet.OData.Common.Models.Products
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CustomerCollection : Collection<Customer>
    {
    }
}
