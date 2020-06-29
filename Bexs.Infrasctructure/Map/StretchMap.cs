using Bexs.Infrasctructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Infrasctructure.Map
{
    public static class StretchMap
    {
        public static Stretch ToList(this Utils.CsvModels.StretchModel entity)
        {
            if (entity != null)
            {
                return new Stretch()
                {
                    From = entity.From,
                    To = entity.To,
                    Value = entity.Value
                };
            }
            return null;
        }
    }
}
