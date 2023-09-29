using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole
{
    public static class ContainerConfig
    {
        // autofac
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            // whoever uses IBusinessLogic, will get a BusinessLogic type
            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>(); // one tweak only ~~ Big deal!

            // nameof: object name -> return a string
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
