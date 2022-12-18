using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.ctore.Namber4
{
    internal class Article
    {
     
        public Article(string nazv, string magNazv, string stoim, string kachestvo)
        {
        }
            public string Nazvanie_F { get; set; }
            public string NazvanieMagazina_F { get; set; }
            public string Stoimost_F { get; set; }
            public string Kachestvo_F { get; set; }
            public string Nazvanie => Nazvanie_F;
            public string NazvanieMagazina => NazvanieMagazina_F;
            public string Stoimost => Stoimost_F;
        public void T()
        {
            Console.WriteLine("Выберите магаизн: 1)Днс 2)Алик 3)Ваелдберис 4)Озон 5)Завершить");
            NazvanieMagazina_F = Console.ReadLine();
            switch (NazvanieMagazina_F)
            {
                case "1":
                    Console.WriteLine("Выберите товар Днс: 1)Телевизор 2)Телефон 3)Пк 4)Ноут 5)Завершить");
                    Nazvanie_F= Console.ReadLine();
                    switch (Nazvanie_F)
                    {
                        case "1":
                            Console.WriteLine("Выберите Цену: 1)30000 2)50000 3)70000 4)100000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Выберите Цену: 1)10000 2)20000 3)30000 4)40000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Выберите Цену: 1)40000 2)60000 3)30000 4)120000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Выберите Цену: 1)10000 2)70000 3)80000 4)100000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "5":
                            return;
                            break;
                    }


                    break;
                case "2":
                    Console.WriteLine("Выберите товар Алик: 1)Панталоны 2)Трусы 3)Повербанк 4)Легенсы 5)Завершить");
                    Nazvanie_F = Console.ReadLine();
                    switch (Nazvanie_F)
                    {
                        case "1":
                            Console.WriteLine("Выберите Цену: 1)1000 2)2500 3)6000 4)10000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Выберите Цену: 1)100 2)2000 3)2500 4)5000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Выберите Цену: 1)3000 2)5000 3)10000 4)13000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Выберите Цену: 1)1000 2)2500 3)6000 4)10000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "5":
                            return;
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Выберите товар Ваелдберис: 1)Штаны 2)Куртка 3)Пальто 4)Ожрелье 5)Завершить");
                    Nazvanie_F = Console.ReadLine();
                    switch (Nazvanie_F)
                    {
                        case "1":
                            Console.WriteLine("Выберите Цену: 1)800 2)2000 3)4000 4)10000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Выберите Цену: 1)3000 2)5000 3)7500 4)10000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Выберите Цену: 1)10000 2)20000 3)30000 4)40000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Выберите Цену: 1)20000 2)90000 3)140000 4)1155000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "5":
                            return;
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Выберите товар Озон: 1)Корпус ПК 2)Провод HDMI 3)Вентилятор 4)Чехол 5)Завершить");
                    Nazvanie_F = Console.ReadLine();
                    switch (Nazvanie_F)
                    {
                        case "1":
                            Console.WriteLine("Выберите Цену: 1)2000 2)4000 3)5000 4)10000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Выберите Цену: 1)300 2)1500 3)3500 4)6500 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Выберите Цену: 1)300 2)1750 3)3450 4)5670 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Выберите Цену: 1)500 2)1000 3)2000 4)3000 5)Завершить");
                            Stoimost_F = Console.ReadLine();
                            switch (Stoimost_F)
                            {
                                case "1":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "2":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "3":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "4":
                                    Console.WriteLine("Спасибо за выш выбор!");
                                    break;
                                case "5":
                                    return;
                                    break;
                            }
                            break;
                        case "5":
                            return;
                            break;
                    }
                    break;
                case "5":
                    Console.WriteLine("BY-BY");
                    return;
                    break;
            }
        }
        public void M()
        {
            Random rand= new Random();
            int[] mas1 = new int[150];
            int[] mas2 = new int[300];
            int[] mas3 = new int[400];
            int[] mas4 = new int[255];
            if (NazvanieMagazina_F== "1")
            {
                for (int i = 0; i < 1; i++)
                {
                    mas1[i] = rand.Next(1,151);
                    Console.WriteLine($"По вашему запросу найдено {mas1[i]} товаров") ;
                }
            }
            if (NazvanieMagazina_F == "2")
            {
                for (int i = 0; i < 1; i++)
                {
                    mas2[i] = rand.Next(1, 301);
                    Console.WriteLine($"По вашему запросу найдено {mas2[i]} товаров");
                }
            }
            if (NazvanieMagazina_F == "3")
            {
                for (int i = 0; i < 1; i++)
                {
                    mas3[i] = rand.Next(1, 401);
                    Console.WriteLine($"По вашему запросу найдено {mas3[i]} товаров");
                }
            }
            if (NazvanieMagazina_F == "4")
            {
                for (int i = 0; i < 1; i++)
                {
                    mas4[i] = rand.Next(1, 256);
                    Console.WriteLine($"По вашему запросу найдено {mas4[i]} товаров");
                }
            }
        }
      
        public void R()
        {
            Random rand = new Random();
            int[] mas1 = new int[1];
            int[] mas2 = new int[1];
            int[] mas3 = new int[1];
            int[] mas4 = new int[1];
            if (Kachestvo_F == NazvanieMagazina_F)
            {
                if (NazvanieMagazina_F=="1")
                {
                    Console.WriteLine("Днс");
                    if (Nazvanie == "1")
                    {
                        if (Stoimost_F=="1")
                        {
                            Console.WriteLine("Телевизор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(27000, 35000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Телевизор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(47000, 55000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Телевизор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(67000, 75000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Телевизор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(97000, 105000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "2")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Телефон");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(7000, 15000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Телефон");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(17000, 25000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Телефон");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(27000, 35000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Телефон");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(37000, 45000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "3")
                    {                        
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Пк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(37000, 45000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Пк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(57000, 65000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Пк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(27000, 35000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Пк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(117000, 125000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "4")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Ноут");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(7000, 15000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Ноут");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(67000, 75000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Ноут");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(67000, 75000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Ноут");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(97000, 105000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                    }
                }
                if (NazvanieMagazina_F == "2")
                {
                    Console.WriteLine("Алик");
                    if (Nazvanie == "1")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(500, 1500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(2000, 3000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(5500, 6500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(7000, 13000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "2")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Трусы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(100, 200);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Трусы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(1500, 2500);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Трусы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(2000, 3000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Трусы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(4000, 5500);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "3")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Повербанк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(2500, 3500);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Повербанк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(4500, 5500);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Повербанк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(7000, 15000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Повербанк");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(127000, 135000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "4")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Легенсы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(500, 1500);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Легенсы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(2000, 3000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Легенсы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(5600, 7000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Легенсы");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(9000, 14000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                    }
                }
                if (NazvanieMagazina_F == "3")
                {
                    Console.WriteLine("Ваелдберис");
                    if (Nazvanie == "1")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(500, 1500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(2000, 3000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(2500, 3500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Панталоны");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(7000, 13000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "2")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Куртка");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(2100, 3200);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Куртка");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(4500, 5500);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Куртка");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(7000, 8000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Куртка");
                            for (int i = 0; i < 1; i++)
                            {
                                mas2[i] = rand.Next(7000, 15000);
                                Console.WriteLine($"Его цена: {mas2[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "3")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Пальто");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(9500, 13500);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Пальто");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(19500, 25500);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Пальто");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(27000, 35000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Пальто");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(37000, 45000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "4")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Ожрелье");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(19500, 21500);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Ожрелье");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(82000, 93000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Ожрелье");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(135600, 147000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Ожрелье");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(109000, 125000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                    }
                }
                if (NazvanieMagazina_F == "4")
                {
                    Console.WriteLine("Озон");
                    if (Nazvanie == "1")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Корпус ПК");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(1500, 2500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Корпус ПК");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(3000, 4500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Корпус ПК");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(4500, 5500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Корпус ПК");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(7000, 13000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "2")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Провод HDMI");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(200, 500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Провод HDMI");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(1000, 2500);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Провод HDMI");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(3000, 4000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Провод HDMI");
                            for (int i = 0; i < 1; i++)
                            {
                                mas1[i] = rand.Next(6000, 7000);
                                Console.WriteLine($"Его цена: {mas1[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "3")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Вентилятор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(200,700);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Вентилятор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(1500, 2550);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Вентилятор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(3000, 4000);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Вентилятор");
                            for (int i = 0; i < 1; i++)
                            {
                                mas3[i] = rand.Next(5000, 6300);
                                Console.WriteLine($"Его цена: {mas3[i]}");
                            }
                        }
                    }
                    if (Nazvanie == "4")
                    {
                        if (Stoimost_F == "1")
                        {
                            Console.WriteLine("Чехол");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(300, 1000);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "2")
                        {
                            Console.WriteLine("Чехол");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(700, 1500);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "3")
                        {
                            Console.WriteLine("Чехол");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(2000, 2500);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                        if (Stoimost_F == "4")
                        {
                            Console.WriteLine("Чехол");
                            for (int i = 0; i < 1; i++)
                            {
                                mas4[i] = rand.Next(2500, 3500);
                                Console.WriteLine($"Его цена: {mas4[i]}");
                            }
                        }
                    }
                }
                               
                
            }
            if (Kachestvo_F != NazvanieMagazina_F)
            {
                Console.WriteLine("Ошибка! Такого товара нет");
            }
        }
           
           
            
        
    }
}
