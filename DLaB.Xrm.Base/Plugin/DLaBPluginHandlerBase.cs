﻿using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.Plugin
{
    /// <summary>
    /// Plugin Handler Base.  Allows for Registered Events, preventing infinite loops, and auto logging
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public abstract class DLaBPluginHandlerBase : GenericPluginHandlerBase<IExtendedPluginContext>
    {
        protected override IExtendedPluginContext CreatePluginContext(IServiceProvider serviceProvider)
        {
            return new DLaBExtendedPluginContextBase(serviceProvider, this);
        }
    }
}