using Bexs.Commom;
using System.Collections.Generic;
using System.Linq;

namespace Bexs.Domain.Route.Models
{
    public class Stretch
    {
        Local from;
        Local to;
        int value;


        public Stretch(string from, string to, int value)
        {
            AssertionConcern.AssertArgumentNotNull(from, "The From must be provided.");
            AssertionConcern.AssertArgumentNotNull(to, "The To must be provided.");
            AssertionConcern.AssertArgumentNotEquals(0, value, "The Value id must be provided.");

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

        public void ChangeValue(int value)
        {
            AssertionConcern.AssertArgumentNotEquals(0, value, "The Value must be provided.");

            this.value = value;

            //Apply(new CalendarDescriptionChanged(this.tenant, this.calendarId, this.name, description));
        }

        public Stretch GetCheapRoute(Local from, Local to)
        {
            var lista = GetStretches(from,to);

            Stretch cheapRoute = lista.Where(x => x.from.AirPort == from.AirPort && x.to.AirPort == to.AirPort).FirstOrDefault();



            return null;
        }

        public IEnumerable<Stretch> GetStretches(Local from, Local to)
        {
            List<Stretch> Lista = new List<Stretch>();

            Lista.Add(new Stretch("GRU","BRC",10));
            Lista.Add(new Stretch("BRC","SCL",5));
            Lista.Add(new Stretch("GRU","CDG",75));
            Lista.Add(new Stretch("GRU","SCL",20));
            Lista.Add(new Stretch("BRC","ORL",56));
            Lista.Add(new Stretch("ORL","CDG",5));
            Lista.Add(new Stretch("SCL","ORL", 20));

            return Lista;
        }

        private IEnumerable<Stretch> GetFromStretches(Local from)
        {
            List<Stretch> Lista = new List<Stretch>();

            Lista.Add(new Stretch("GRU", "BRC", 10));
            Lista.Add(new Stretch("BRC", "SCL", 5));
            Lista.Add(new Stretch("GRU", "CDG", 75));
            Lista.Add(new Stretch("GRU", "SCL", 20));
            Lista.Add(new Stretch("BRC", "ORL", 56));
            Lista.Add(new Stretch("ORL", "CDG", 5));
            Lista.Add(new Stretch("SCL", "ORL", 20));

            return Lista.FindAll(x => x.from == from);
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
    }
}
