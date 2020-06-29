using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Utils.CsvModels
{
    public class StretchModel
    {
        public string From { get;  set; }

        public string To { get;  set; }

        public int Value { get;  set; }
    }
}
