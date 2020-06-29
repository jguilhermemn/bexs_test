using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Utils
{
    public class Validations
    {

        public static bool Ext(string value, string ext)
        {
            AssertionConcern.AssertArgumentNotEmpty(value, "Value cannot be null.");
            AssertionConcern.AssertArgumentNotEmpty(ext, "Ext cannot be null.");

            return value.EndsWith(ext);
        }
    }

}
