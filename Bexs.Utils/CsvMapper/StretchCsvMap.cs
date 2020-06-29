using Bexs.Utils.CsvModels;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Utils.CsvMapper
{
    public class StretchCsvMap : ClassMap<StretchModel>
    {  
        public StretchCsvMap()
        {
            Map(m => m.From).Index(0);
            Map(m => m.To).Index(1);
            Map(m => m.Value).Index(2);
        }
    }
}
