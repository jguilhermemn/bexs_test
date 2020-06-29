using Bexs.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bexs.Domain.Route.Models
{
    public class Route
    {
        private IList<Stretch> stretch;
        Local from;
        Local to;
        int TotalCost;

        public Route(Local from, Local to)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");

            this.from = from;
            this.to = to;
        }

        public IList<Stretch> NewRoute(Local from, Local to) 
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");

            return null;
        }
    }
}
