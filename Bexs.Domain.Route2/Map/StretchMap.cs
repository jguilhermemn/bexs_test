using Bexs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Domain.Map
{
    public static class StretchMap
    {
        public static Stretch ToList(this Infrasctructure.Models.Stretch entity)        
        {
            if (entity != null)
            {
                return new Stretch(entity.From, entity.To, entity.Value);
            }
            return null;
        }
    }
}
