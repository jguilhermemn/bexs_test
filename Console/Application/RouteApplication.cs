using Bexs.Domain.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Application
{
    public class RouteApplication
    {
        private IRouteApplication IRouteApplication;
        RouteApplication(IRouteApplication iRouteApplication)
        {
            this.IRouteApplication = iRouteApplication;
        }
    }
}
