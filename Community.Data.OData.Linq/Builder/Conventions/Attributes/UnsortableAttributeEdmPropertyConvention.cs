﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.OData.Linq.Builder.Conventions.Attributes
{
    using System;

    using Community.OData.Linq.Annotations;
    using Community.OData.Linq.Common;

    internal class UnsortableAttributeEdmPropertyConvention : AttributeEdmPropertyConvention<PropertyConfiguration>
    {
        public UnsortableAttributeEdmPropertyConvention()
            : base(attribute => attribute.GetType() == typeof(UnsortableAttribute), allowMultiple: false)
        {
        }

        public override void Apply(PropertyConfiguration edmProperty, 
            StructuralTypeConfiguration structuralTypeConfiguration, 
            Attribute attribute,
            ODataConventionModelBuilder model)
        {
            if (edmProperty == null)
            {
                throw Error.ArgumentNull("edmProperty");
            }

            if (!edmProperty.AddedExplicitly)
            {
                edmProperty.IsNotSortable();
            }
        }
    }
}
