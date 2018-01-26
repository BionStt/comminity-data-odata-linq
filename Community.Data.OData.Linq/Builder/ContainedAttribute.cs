﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.Data.OData.Linq.Builder
{
    using System;

    /// <summary>
    /// Mark a navigation property as containment.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ContainedAttribute : Attribute
    {
    }
}
