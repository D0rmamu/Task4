using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.ctore.Namber2
{
     class Player :  IPlayable, IRecodable
    {
        int[] D = new int[15];
        int[] M = new int[15];
        int[] T = new int[15];       
        Random rnd = new Random();
        public void Play()
        {
            Console.WriteLine("Запуск песни");
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rnd.Next();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("песня играет");
                Console.ResetColor();

            }
        }           
                  
        public void Pause()
        {
            Console.WriteLine("Песня остановлена");
            for (int i = 0; i <M.Length; i++)
            {
                M[i] = rnd.Next();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Песня на паузе");
                Console.ResetColor();
            }         
        }
        public void Record()
        {
            Console.WriteLine("Идет запись песни");
            for (int i = 0; i < T.Length; i++)
            {      
                T[i] = rnd.Next();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Запись песни");
                Console.ResetColor();
            }
        }
        public void Stop()
        {
            
                Console.WriteLine("Песня остановлена");
            
        }
        
    }
}
