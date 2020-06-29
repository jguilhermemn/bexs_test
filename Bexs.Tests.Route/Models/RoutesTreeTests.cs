using Bexs.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Bexs.Domain.Route.Models.Tests
{
    [TestClass()]
    public class RoutesTreeTests
    {
        [TestMethod()]
        public void GetTreesTest()
        {
            //StretchTree routesTree = new StretchTree(new Local("GRU"));
            //Route route = new Route("GRU", "CDG");

            //var temp = routesTree.BuildRoutes(route);

            //Assert.IsTrue(true);
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

            return Lista.FindAll(x => x.from.AirPort == from.AirPort);
        }
    }
}