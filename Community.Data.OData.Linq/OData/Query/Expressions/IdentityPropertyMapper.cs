﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.OData.Linq.OData.Query.Expressions
{
    internal class IdentityPropertyMapper : IPropertyMapper
    {
        public string MapProperty(string propertyName)
        {
            return propertyName;
        }
    }
}
