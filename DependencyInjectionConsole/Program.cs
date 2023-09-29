using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// we have to pass dependency down in our ctor - use Autofac Nuget (Reference -> add...)
            //BusinessLogic businessLogic = new BusinessLogic();

            //businessLogic.ProcessData();
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
