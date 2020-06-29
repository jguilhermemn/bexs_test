using Bexs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Domain.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteApplicationService : IRouteApplicationService
    {
        private IEnumerable<Stretch> allStretch;
        public string BuildRoutes(string From, string To)
        {
            Route route = new Route(From, To);

            // 1 - Obter todas as rotas
            allStretch = GetStretches();

            List<Route> routeList = new List<Route>();
            
            //2  Todas as possiveis rotas
            foreach (var item in allStretch.Where(x => x.from.AirPort == route.From.AirPort))
            {
                Route routeAviable = new Route(route.From.AirPort, route.To.AirPort);

                Calculate(item, route, ref routeAviable);

                routeList.Add(routeAviable);

            }

            //3 rota mais barata
            return routeList.OrderBy(x => x.Value).First().Build();
        }

        /// <summary>
        /// Calcula o valor e tambem todos os trechos percorridos
        /// </summary>
        /// <param name="result">Enumeração com a lista de Stretch(Trecho) a ser calculada</param>
        /// <param name="to">Destino</param>
        /// <returns>Retorna uma string com os trechos encontrados e a somatoria dos valores entres eles.</returns>
        private void Calculate(Stretch result, Route route, ref Route routeAviable)
        {
            routeAviable.AddValue(result.value);
            routeAviable.AddStretch(result);

            if (route.To.AirPort != result.to.AirPort)
            {
                var next = allStretch.Where(x => x.from.AirPort == result.to.AirPort).FirstOrDefault();

                if (next != null)
                    Calculate(next, route, ref routeAviable);
            }
        }


        private IEnumerable<Stretch> GetFromStretches(Local from)
        {
            return GetStretches().ToList().FindAll(x => x.from.AirPort == from.AirPort);
        }

        private IEnumerable<Stretch> GetStretches()
        {
            RouteQueryService routeQueryService = new RouteQueryService();

            var result = routeQueryService.GetAllStretch();
            
            return result;
        }
    }
}
