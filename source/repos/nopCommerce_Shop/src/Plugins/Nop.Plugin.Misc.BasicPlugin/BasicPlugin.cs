using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.BasicPlugin
{
    public class BasicPlugin : BasePlugin
    {
        public BasicPlugin() { }

        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }
    }
}
