using Bexs.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bexs.Domain.Route.Models
{
    public class Local
    {
        public string AirPort { get; }

        public Local(string airPort)
        {
            AssertionConcern.AssertArgumentNotNull(airPort, "The airPort must be provided.");
            AssertionConcern.AssertArgumentLength(airPort, 3, "The To must be provided.");            

            this.AirPort = airPort.ToUpper();
        }
    }
}
