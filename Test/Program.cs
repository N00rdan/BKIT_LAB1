using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Koef = new double[3];
            bool isAnswerCorrect;
            for(int i = 0; i<3; i++)
                do
                {
                    Console.Write("Введте коэфиценты: ");
                    string str = Console.ReadLine();
                    isAnswerCorrect = double.TryParse(str, out Koef[i]);
                    if (!isAnswerCorrect)
                        Console.WriteLine("Вы не ввели число");

                } while (!isAnswerCorrect);


            double disc = Koef[1] * Koef[1] - 4 * Koef[0] * Koef[2];
            Console.WriteLine("Дискриминант: " + disc);
           
            if (disc<0) Console.WriteLine("Корней нет");
            else if(disc==0)
            {
                Console.Write("Один корень: ");
                Console.WriteLine(-Koef[1]/(2* Koef[0]));
            }
            else
            {
                Console.Write("Первый корень: ");
                Console.WriteLine((-Koef[1] + Math.Sqrt(disc)) / (2 * Koef[0]));
                Console.Write("Второй корень: ");
                Console.WriteLine((-Koef[1] - Math.Sqrt(disc)) / (2 * Koef[0]));
            }

            Console.ReadLine();
        }
    }
}
