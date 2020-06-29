using Bexs.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bexs.Domain.Control.Models
{
    public class Route
    {
        string from;
        string to;
        int value;
        string line;

        public Route(string from, string to, int value)
        {

            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");
            AssertionConcern.AssertArgumentNotEquals(0, value, "The To must be provided.");

            AssertionConcern.AssertArgumentLength(from, 3, "The To must be provided.");
            AssertionConcern.AssertArgumentLength(to, 3, "The To must be provided.");

            this.from = from.ToUpper();
            this.to = to.ToUpper();
            this.value = value;
        }

        public void Apply()
        {

        }
    }
}
