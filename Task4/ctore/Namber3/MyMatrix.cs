using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.ctore.Namber3
{
    public class MyMatrix
    {

        public void MASS()
        {
            Random rnd = new Random();
            int[,] mas = new int[1000,1000];
            Console.WriteLine("Введите i:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите j:");
            int b = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mas[i,j]=rnd.Next(1,1001);
                    Console.WriteLine(mas[i, j]+"");
                }
                Console.WriteLine();
            }
        }
    }
}
