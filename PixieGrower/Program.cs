using System;

namespace PixieGrower
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            PixieFarmer farmer = new PixieFarmer();
            int harvested = 0;
            int day = 0;

            while (keepGoing)
            {
                WriteTitle();
                Console.WriteLine("Day " + day);
                Console.WriteLine("You have {0} terrariums, with total {1} pixies.", farmer.TerrariumCount(), farmer.CountAllPixies());
                Console.WriteLine("You have {0} units of pixie dust.", farmer.Dust);

                Console.WriteLine("Terrariums:");
                for (int i = 0; i < farmer.TerrariumCount(); i++)
                {
                    Console.WriteLine("Terrarium {0}: {1} pixies", i+1, farmer.CountPixies(i));
                }
                Console.WriteLine();
                if (harvested != 0)
                {
                    Console.WriteLine("You harvest {0} pixie dust.", harvested);
                }
                else Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Type terrarium number to harvest, or W to wait, Q to quit.");
                if (farmer.Dust >= 100 && farmer.TerrariumsNotFull())
                {
                    Console.WriteLine("Type T to purchase a new terrarium for 100 pixie dust.");
                }
                else Console.WriteLine();
                
                ConsoleKeyInfo input = Console.ReadKey();
                int inputNumber;
                if (int.TryParse(input.KeyChar.ToString(), out inputNumber))
                {
                    if (inputNumber > 0 && inputNumber <= farmer.TerrariumCount())
                    {
                        harvested = (farmer.Harvest(inputNumber - 1));
                    }
                }
                else
                {
                    switch (input.KeyChar)
                    {
                        case 'w':
                        case 'W':
                            farmer.Wait();
                            day++;
                            break;
                        case 't':
                        case 'T':
                            if (farmer.Dust >= 100 && farmer.TerrariumCount() < farmer.MAX_TERRARIUMS)
                            {
                                farmer.RemoveDust(100);
                                farmer.AddTerrarium();
                            }
                            break;
                        case 'q':
                        case 'Q':
                            keepGoing = false;
                            break;
                        default:
                            break;
                    }
                }
                Console.Clear();
            }



        }

        private static void WriteTitle()
        {
            Console.WriteLine("┌────────────┐");
            Console.WriteLine("│PIXIE FARMER│");
            Console.WriteLine("└────────────┘");
            Console.WriteLine();
        }
    }
}
