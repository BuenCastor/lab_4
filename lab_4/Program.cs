using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        const double StartX = 10.3;
        const double dX = 0.7;
        static double Function(double x)
        {
            return Math.Sqrt(Math.Pow(2.76 * x, 3) + Math.Pow(0.5 * x, 5)) / 1000 + 65;
        }

        static void Main(string[] args)
        {
            double[] arr = new double[10];
            double x = StartX;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {

                arr[i] = Function(x);
                x += dX;
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
            }
            double aMin = arr[arr.GetUpperBound(0)];
            double aMax = arr[arr.GetLowerBound(0)];
            double aAvg = 0;
            double sum = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                aAvg += arr[i];
            }
            aAvg = aAvg / arr.GetLength(0);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] < aAvg)
                    sum = sum + arr[i];
            }

            Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
            Console.WriteLine("Сума елементiв масиву менших за середнє значення: {0:0.0000}", sum);
            Console.ReadKey(true);

        }
    }
}
