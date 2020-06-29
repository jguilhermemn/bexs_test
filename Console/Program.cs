using Bexs.Domain.Application;
using Console.Application;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            Ninject.IKernel kernal = new StandardKernel();

            kernal.Load(Assembly.GetExecutingAssembly());

            IRouteApplicationService _IRouteApplicationService = kernal.Get<IRouteApplicationService>();

            string from = string.Empty;
            string to = string.Empty;

            do
            {
                var validationFrom = GetFrom(ref from);
                var validationTo = GetTo(ref to);

                if (validationFrom && validationTo)
                {
                    var resultado = _IRouteApplicationService.BuildRoutes(from, to);
                    System.Console.WriteLine(resultado);
                }

            }
            while (true);


            System.Console.ReadKey();

        }

        public static bool GetFrom(ref string from)
        {
            System.Console.WriteLine("Informe a origem: \n");
            from = System.Console.ReadLine();

            if (from != null && from.Length == 3)
                return true;
            else
            {
                System.Console.WriteLine("A origem deve ter 3 caracteres");
                return false;
            }

        }


        public static bool GetTo(ref string to)
        {
            System.Console.WriteLine("Informe o destino: \n");
            to = System.Console.ReadLine();

            if (to != null && to.Length == 3)
                return true;
            else
            {
                System.Console.WriteLine("A origem deve ter 3 caracteres");
                return false;
            }

        }
        public void BuildRoutes()
        {

            RouteApplicationService routeApplicationService = new RouteApplicationService();

            routeApplicationService.BuildRoutes("GRU", "CDG");

            //this.IRouteApplication.BuildRoutes("GRU", "CDG");
        }

    }
}
