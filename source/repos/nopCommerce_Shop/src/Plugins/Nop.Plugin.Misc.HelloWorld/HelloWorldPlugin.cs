using Nop.Services.Plugins;
using Nop.Web.Framework.Menu;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.HelloWorld
{
    public class HelloWorldPlugin : BasePlugin, IAdminMenuPlugin
    {
        public override string GetConfigurationPageUrl() => "/Admin/HelloWorld/Index";

        public async Task ManageSiteMapAsync(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode
            {
                SystemName = "HelloWorld",
                Title = "Hello World",
                ControllerName = "HelloWorld",
                ActionName = "Index",
                Visible = true,
                RouteValues = new { area = "Admin" }
            };

            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Third party plugins");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);

            await Task.CompletedTask;
        }

        public override Task InstallAsync() => base.InstallAsync();
        public override Task UninstallAsync() => base.UninstallAsync();
    }
}
