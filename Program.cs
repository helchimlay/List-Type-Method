using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            MetodaLista metodaLista = new MetodaLista();

            PobierzWartosci(metodaLista);

            metodaLista.MetodaZLista(metodaLista.PrimaryList);
            WyswietlWartosci(metodaLista);
            Console.ReadKey();
        }

        private static void PobierzWartosci(MetodaLista _object)
        {
            _object.a = double.Parse(Console.ReadLine());
            _object.PrimaryList.Add(_object.a);
            _object.b = double.Parse(Console.ReadLine());
            _object.PrimaryList.Add(_object.b);
            _object.c = double.Parse(Console.ReadLine());
            _object.PrimaryList.Add(_object.c);
        }


        private static void WyswietlWartosci(MetodaLista _object)
        {
            List<double> dowyswietlenia = _object.MetodaZLista(_object.PrimaryList);
            Console.WriteLine("Najmniejsza wartosc: "+dowyswietlenia[0]);
            Console.WriteLine("Najwieksza wartosc: " + dowyswietlenia[1]);
            Console.WriteLine("Srednia wartosc: " + dowyswietlenia[2]);
        }
    }
}
