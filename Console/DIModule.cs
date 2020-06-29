using Bexs.Domain.Application;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRouteApplicationService>().To<RouteApplicationService>();
        }
    }
}
