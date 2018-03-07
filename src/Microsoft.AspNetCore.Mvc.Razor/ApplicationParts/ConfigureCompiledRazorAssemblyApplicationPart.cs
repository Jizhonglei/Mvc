// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    /// <summary>
    /// Configures an assembly as a <see cref="CompiledRazorAssemblyPart"/>.
    /// </summary>
    public class ConfigureCompiledRazorAssemblyApplicationPart : ConfigureApplicationPart
    {
        /// <inheritdoc />
        public override void Configure(
            ApplicationPartManager applicationPartManager,
            Assembly assembly,
            string configuration)
        {
            if (applicationPartManager == null)
            {
                throw new ArgumentNullException(nameof(applicationPartManager));
            }

            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            applicationPartManager.ApplicationParts.Add(new CompiledRazorAssemblyPart(assembly));
        }
    }
}
