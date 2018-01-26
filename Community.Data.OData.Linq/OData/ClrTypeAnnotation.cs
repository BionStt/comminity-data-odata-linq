﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.Data.OData.Linq.OData
{
    using System;

    using Microsoft.OData.Edm;

    /// <summary>
    /// Represents a mapping from an <see cref="IEdmType"/> to a CLR type.
    /// </summary>
    public class ClrTypeAnnotation
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ClrTypeAnnotation"/> class.
        /// </summary>
        /// <param name="clrType">The backing CLR type for the EDM type.</param>
        public ClrTypeAnnotation(Type clrType)
        {
            this.ClrType = clrType;
        }

        /// <summary>
        /// Gets the backing CLR type for the EDM type.
        /// </summary>
        public Type ClrType { get; private set; }
    }
}
