using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SudokuVerify.Infra.IoC.ContainerIoC
{
    public class DependencyContainer
    {
        private readonly static Container _container = new Container();

        static DependencyContainer()
        {
            RegisterServices();
        }

        public static Container RegisterServices()
        {
            _container.Register<IAppServiceBase>
        }
    }
}
