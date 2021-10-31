using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int gameNumber = number.Next(12,121); // Принимает gameNumber число от 12 до 120
            Console.WriteLine("Введите количество пользователей");
            int people = int.Parse(Console.ReadLine());
            List <string> nikname = new List<string>();
            Console.WriteLine($"Число: {gameNumber}");
            if (people>1) // если пользователей больше 1, то запускаем цикл, чтобы получить их никнеймы
            {
                for (int i=1; i<= people; i++)
                {
                    Console.WriteLine($"Введите никнейм пользователя {i}");
                    nikname.Add(Console.ReadLine());
                }
                while (gameNumber != 0 && gameNumber > 0)
                {
                    for (int j = 0; gameNumber != 0 && gameNumber > 0 && j < people; j++)
                    {
                        Console.WriteLine($"Игрок {nikname[j]} введите число от 1 до 4");
                        int userTry = int.Parse(Console.ReadLine());
                        if (userTry > 0 && userTry < 5)
                        {
                            gameNumber -= userTry;
                            Console.WriteLine($"Число: {gameNumber}");
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок {nikname[j]} выиграл");
                            }
                        }
                    }
                }
            }
            else 
                if (people == 1)
                {

                    Console.WriteLine($"Введите никнейм пользователя");
                    nikname.Add(Console.ReadLine());
                    nikname.Add("computer");
                while (gameNumber != 0 && gameNumber > 0)
                {
                    for (int j = 0; gameNumber != 0 && gameNumber > 0 && j < people+1; j++)
                    {
                        if (nikname[j] == "computer")
                        {
                            int userTry = number.Next(1, 5);
                            if (gameNumber <5)
                            {
                                userTry = gameNumber; // для того, чтобы компьютер мог выиграть, когда остался 1 ход
                            }
                            if (userTry > 0 && userTry < 5)
                            {
                                Console.WriteLine($"Компьютер ввел число {userTry}");
                                gameNumber -= userTry;
                                Console.WriteLine($"Число: {gameNumber}");
                                if (gameNumber == 0)
                                {
                                    Console.WriteLine($"Игрок {nikname[j]} выиграл");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Игрок {nikname[j]} введите число от 1 до 4");
                            int userTry = int.Parse(Console.ReadLine());
                            if (userTry > 0 && userTry < 5)
                            {
                                gameNumber -= userTry;
                                Console.WriteLine($"Число: {gameNumber}");
                                if (gameNumber == 0)
                                {
                                    Console.WriteLine($"Игрок {nikname[j]} выиграл");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
