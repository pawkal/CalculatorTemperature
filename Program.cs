using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTemperature
{
    internal class CalcTemperature
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temperature w stopniach Fahrenheita");
            F = double.Parse(Console.ReadLine());
            C = 5.0 / 9 * (F - 32);
            Console.WriteLine(C + "  Temperatura w stopniach Celsjusza");
            Console.ReadKey();
        }
    }
}
