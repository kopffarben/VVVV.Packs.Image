﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VVVV.PluginInterfaces.V2;
using System.Reflection;
using System.IO;

namespace VVVV.Nodes.EDSDK
{
    [Startable]
    public class ManageDependencies : IStartable
    {
        public void Start()
        {
            var pathToThisAssembly = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var pathToBinFolder = Path.Combine(pathToThisAssembly, "Dependencies", "EDSDK", "x86");
            var envPath = Environment.GetEnvironmentVariable("PATH");
            envPath = string.Format("{0};{1}", envPath, pathToBinFolder);
            Environment.SetEnvironmentVariable("PATH", envPath);
        }

        public void Shutdown()
        {
        }
    }
}
