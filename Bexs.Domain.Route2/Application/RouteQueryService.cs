using Bexs.Domain.Map;
using Bexs.Domain.Models;
using Bexs.Infrasctructure.Services;
using Bexs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Domain.Application
{
    public class RouteQueryService
    {
        public IEnumerable<Stretch> GetAllStretch()
        {
            RouteDataService routeData = new RouteDataService();

            return routeData.GetAllStretch().Select(x => x.ToList()).ToList();
        }
    }
}
