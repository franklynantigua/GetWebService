using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetWebService.WebServices;

namespace GetWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServices.GlobalWeatherSoap ws= new GlobalWeatherSoapClient();
            string listaCiudadesPeru = ws.GetCitiesByCountry("PERU");

            Console.WriteLine("Las Cuidades de Peru Son :"  + listaCiudadesPeru);

            Console.WriteLine("");


            string listaCiudadesBrazil = ws.GetCitiesByCountry("BRAZIL");

            Console.WriteLine("Las Cuidades de BRAZIL Son :" + listaCiudadesBrazil);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
