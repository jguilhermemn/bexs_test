using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Application
{
    public interface IRouteApplication
    {
        string BuildRoutes(string From, string To);
    }
}
