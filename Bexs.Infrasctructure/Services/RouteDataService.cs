using Bexs.Infrasctructure.Map;
using Bexs.Infrasctructure.Models;
using Bexs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Infrasctructure.Services
{
    public class RouteDataService
    {
        public IEnumerable<Stretch> GetAllStretch()
        {
            CsvManager<Stretch> csv = new CsvManager<Stretch>(@"C:\Temp\bexs.csv");

            return  csv.Read().ToList().Select(x => x.ToList());
        }
    }
}
