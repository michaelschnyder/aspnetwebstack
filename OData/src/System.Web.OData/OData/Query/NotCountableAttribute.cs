﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.OData.Query
{
    /// <summary>
    /// Represents an <see cref="Attribute"/> that can be placed on a property to specify that
    /// the $count cannot be applied on the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NotCountableAttribute : Attribute
    {
    }
}