using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket bränsle går åt liter/mil?");
            string str1 = Console.ReadLine();
            double bränsleförbrukning = Convert.ToDouble(str1);
            Console.WriteLine("Hur många liter är tanken på?");
            string str2 = Console.ReadLine();
            double tanken = Convert.ToDouble(str2);
            Console.WriteLine("Hur långt har ni/du kört i km?");
            string str3 = Console.ReadLine();
            double kört = Convert.ToDouble(str3);

            double summa1 = (kört / 10) * bränsleförbrukning;
            double summa2 = tanken - summa1;
            double summa3 = (summa2 / bränsleförbrukning) * 10;
            Console.WriteLine("Bränsle kvar i tanken " + summa3 + " km");
        }
    }
}
