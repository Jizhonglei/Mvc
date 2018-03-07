// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    /// <summary>
    /// Specifies a <see cref="ConfigureApplicationPart"/> type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class ConfigureApplicationPartAttribute : Attribute
    {
        public ConfigureApplicationPartAttribute(Type configureType)
        {
            ConfigureType = configureType ?? throw new ArgumentNullException(nameof(configureType));
        }

        public Type ConfigureType { get; }
    }
}
