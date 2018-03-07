// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    /// <summary>
    /// Specifies a contract for configuring <see cref="ApplicationPartManager"/>.
    /// <para>
    /// By default, Mvc registers each application assembly that it discovers as an <see cref="AssemblyPart"/>.
    /// Assemblies can be optionally annotated with an <see cref="ConfigureApplicationPartAttribute"/> that specify an
    /// instance of <see cref="ConfigureApplicationPart"/>. The type allows assemblies to determine how the assembly
    /// is registered with the <see cref="ApplicationPartManager"/>.
    /// </para>
    /// </summary>
    public abstract class ConfigureApplicationPart
    {
        public static readonly string DefaultConfigurationName = "Default";

        /// <summary>
        /// Configures an <see cref="ApplicationPartManager"/>.
        /// </summary>
        /// <param name="applicationPartManager">The <see cref="ApplicationPartManager"/>.</param>
        /// <param name="assembly">The <see cref="Assembly"/>.</param>
        /// <param name="configuration">
        /// A name to uniquely identify the caller. In the default case, this value is <see cref="DefaultConfigurationName"/>.
        /// </param>
        public abstract void Configure(
            ApplicationPartManager applicationPartManager,
            Assembly assembly,
            string configuration);
    }
}
