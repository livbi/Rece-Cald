﻿using System;

namespace Rece_Cald
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ..................................................... \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                  qqqq         qqqq");
            Console.WriteLine("                    qqq       qqq");
            Console.WriteLine("                      qq     qq");
            Console.WriteLine("                        q   q");
            Console.WriteLine("                          . ");
            Console.WriteLine("                       qq   qq");
            Console.WriteLine("                     qqq     qqq");
            Console.WriteLine("                   qqqq       qqqq ");
            Console.WriteLine("                 qqqqq         qqqqq \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ..................................................... \n ");

            while (true)
            {

                Console.Write("> Introduceti, va rog, un numar de jucatori :  \n");
                int j = int.Parse(Console.ReadLine());
                string[] jucatori = new string[j];

                int[] rnd = new int[j];
                int[] rnd1 = new int[j];
                int[] rnd2 = new int[j];
                int[] rnd3 = new int[j];
                for (int k = 0; k < jucatori.Length; k++)
                {
                    Random random = new Random();
                    rnd1[k] = random.Next(0, 10);
                    rnd2[k] = random.Next(0, 100);
                    rnd3[k] = random.Next(-100, 100);
                    //double rnd4 = random.NextDouble();
                    Console.Write($" Numele jucatorului {k + 1} este :  ");
                    jucatori[k] = Console.ReadLine();
                }
                SelectGameLevel();
                int lvl = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                //Double t = new double();
                int incercari = new int();

                switch (lvl)
                {
                    case 1:
                        rnd = rnd1; ;
                        incercari = 3;
                        Console.WriteLine($"> Am ales un numar pana la 10. Poti sa il ghicesti din {incercari} incercari ?\n");
                        break;
                    case 2:
                        rnd = rnd2;
                        incercari = 7;
                        Console.WriteLine($"> Am ales la intamplare un numar pana la 100. Poti sa il ghicesti din {incercari} incercari ?\n");
                        break;
                    case 3:
                        rnd = rnd3;
                        incercari = 11;
                        Console.WriteLine($"> Tocmai s-a generat un numar oarecare! Poti sa il ghicesti din {incercari} incercari ?\n");
                        break;
                }

                for (int k = 0; k < jucatori.Length; k++)
                {
                    Console.WriteLine($" Este randul tau {jucatori[k]} \n");


                    int[] a = new int[incercari];

                    for (int i = 0; i < incercari; i++)
                    {
                        Console.Write($" Mai ai {incercari - i} incercari la dispozitie. Ce numar crezi ca e ?  ");
                        a[i] = Convert.ToInt32(Console.ReadLine());

                        //double x = a[i] - rnd[k];

                        if (a[i] > rnd[k])
                        {
                            Console.WriteLine(" Prea mult...\n");
                        }
                        else if (a[i] < rnd[k])
                        {
                            Console.WriteLine(" Prea putin... \n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine();
                            Console.WriteLine($"" +
                                $" Felicitari {jucatori[k]} ! ' {a[i]} ' este numarul corect !\n\n");
                            break;
                        }
                    }
                }

                //Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("   Game over   \n\n\n");
                Console.ReadLine();
                Console.WriteLine("> ...infinite loop from here... \n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                // string joc = Console.ReadLine();
            }

        }

        private static void SelectGameLevel()
        {
            Console.WriteLine(" ");
            Console.WriteLine("> Pentru a incepe jocul, selectati un nivel de dificultate \n");
            Console.WriteLine("  1  -  nivel usor \n");
            Console.WriteLine("  2  -  nivel mediu \n");
            Console.WriteLine("  3  -  nivel greu \n");
        }
    }
}
