using System;
using System.Diagnostics;

namespace TableGolovina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг изменения значения");
            double step = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько значений вы хотите проверить(целое число)");
            int quantity = Convert.ToInt32(Console.ReadLine()); // количество значений
            CounFunction(quantity, step);


        }
        static void CounFunction(int x, double y)
        {
            double[] function = new double[x];
            string[] strFunction = new string[x];
            int[] count = new int[x];
            int max = 0;
            int maxNumber = 0;
            int lenstring;
            double gCount = 0;
            for (int i = 0; i < x; i++)
            {
                function[i] = gCount * gCount  + gCount + 2;
                strFunction[i] = Convert.ToString(function[i]);
                if (strFunction[i].Length >= max)
                {
                    max = strFunction[i].Length;
                    if (max % 2 != 0)
                    {
                        strFunction[i] = strFunction[i] + " ";
                    }
                    maxNumber = i;
                }
                gCount += y;
            }
            gCount = 0;
            max++;
            Console.WriteLine("  x  \t  y  ");
            for (int i = 0; i < x; i++)
            {
                if (strFunction[i].Length != max)
                {
                    lenstring = Convert.ToInt32((max - strFunction[i].Length) / 2);
                    for (int b = 1; b < lenstring + 1; b++)
                    {
                        strFunction[i] = "-" + strFunction[i] + "-";
                    }
                }
             Console.WriteLine( $"|{gCount}|\t|{strFunction[i]}|");
                gCount += y;
            }
        }
        
           
    }
         
        
        
    
}
