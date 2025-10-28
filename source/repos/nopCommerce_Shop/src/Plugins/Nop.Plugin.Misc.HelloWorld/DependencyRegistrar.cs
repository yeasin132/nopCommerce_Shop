using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugin.Misc.HelloWorld.Services;

namespace Nop.Plugin.Misc.HelloWorld
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<HelloWorldService>().As<IHelloWorldService>().InstancePerLifetimeScope();
        }

        public int Order => 1;
    }
}
