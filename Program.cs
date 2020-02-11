using System;

namespace Fibunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibunacci = 0;
            int sumatoria =0;
            int num1 = 1;
            int num2 = 1;
            do
            {
                fibunacci = num1 + num2;
                num2 = num1;
                num1 = fibunacci;
                if (fibunacci % 2 == 0)
                {
                    sumatoria += fibunacci;
                }
            } while (fibunacci < 4000000);

            Console.WriteLine("La sumatoria es " + sumatoria);
            Console.WriteLine("el ultimo numero Fibunacci es :" +fibunacci);
        }

    }
}
