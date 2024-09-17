using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PlatonovaPE.Sprint0.Task2.V0.Libb;

namespace Tyuiu.PlatonovaPE.Sprint0.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.PlatonovaPE.Sprint0.Task2.V0.Libb
            Console.WriteLine(DataService.GetMessage("Полина"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
