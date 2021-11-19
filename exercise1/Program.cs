using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длинны окружности L");
            int L = Convert.ToInt32(Console.ReadLine());
            double R = L / 2/ Math.PI;
            double S = Math.PI*R*R;
            Console.WriteLine("Радиус={0}", R);
            Console.WriteLine("Площадь={0}", S);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
