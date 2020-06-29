using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Infrasctructure.Models
{

    /// <summary>
    /// Model que representa o arquivo csv
    /// </summary>
    public class Stretch
    {
        [Index(0)]
        public string From { get; set; }
        [Index(1)]
        public string To { get; set; }
        [Index(2)]
        public int Value { get; set; }
    }
}
