using Bexs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bexs.Domain.Models
{
    public class Stretch : IEquatable<Stretch>
    {
        public Local from { get; private set; }
        public Local to { get; private set; }
        public int value { get; private set; }

        public List<Stretch> ChildStretchs { get; private set; }
        public Stretch ChildStretch { get; private set; }

        public Stretch(string from, string to, int value)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");
            AssertionConcern.AssertArgumentNotEquals(0, value, "The Value id must be provided.");

            this.ChildStretchs = new List<Stretch>();
            this.from = new Local(from);
            this.to = new Local(to);
            this.value = value;
        }

        public Stretch(string from, string to)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");

            this.from = new Local(from);
            this.to = new Local(to);
        }

        public void AddStretch(Stretch Stretch)
        {
            ChildStretchs.Add(Stretch);
        }

        public void SetChildStretch(string from, string to, int value)
        {
            ChildStretch = new Stretch(from, to, value);
        }

        public void ChangeValue(int value)
        {
            AssertionConcern.AssertArgumentNotEquals(0, value, "The Value must be provided.");

            this.value = value;
        }

        public IEnumerable<Stretch> GetStretches(Local from, Local to)
        {
            List<Stretch> Lista = new List<Stretch>();

            Lista.Add(new Stretch("GRU", "BRC", 10));
            Lista.Add(new Stretch("BRC", "SCL", 5));
            Lista.Add(new Stretch("GRU", "CDG", 75));
            Lista.Add(new Stretch("GRU", "SCL", 20));
            Lista.Add(new Stretch("BRC", "ORL", 56));
            Lista.Add(new Stretch("ORL", "CDG", 5));
            Lista.Add(new Stretch("SCL", "ORL", 20));

            return Lista;
        }

        private IEnumerable<Stretch> GetToStretches(Local to)
        {
            List<Stretch> Lista = new List<Stretch>();

            Lista.Add(new Stretch("GRU", "BRC", 10));
            Lista.Add(new Stretch("BRC", "SCL", 5));
            Lista.Add(new Stretch("GRU", "CDG", 75));
            Lista.Add(new Stretch("GRU", "SCL", 20));
            Lista.Add(new Stretch("BRC", "ORL", 56));
            Lista.Add(new Stretch("ORL", "CDG", 5));
            Lista.Add(new Stretch("SCL", "ORL", 20));
            return Lista.FindAll(x => x.to == to);
        }

        public bool Equals(Stretch obj)
        {
            return from.AirPort == obj.from.AirPort;
        }
        public override int GetHashCode()
        {
            return from.AirPort.GetHashCode();
        }
    }
}
