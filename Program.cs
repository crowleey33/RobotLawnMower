using System;

namespace RobotLawnMower
{
    class Program
    {
        static void Main(string[] args)
        {

            Garden garden = new Garden();
            Robot robot = new Robot(1,1);

            int test = garden.GardenSize.GetLength(0);
            int test1 = garden.GardenSize.GetLength(1);
            Console.WriteLine(test + " " + test1);

            for (int i = 0; i < test; i++)
            {
                for (int j = 0; j < test1; j++)
                {
                    if (garden.GardenBool[i, j] == true)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("0 ", "\t");                        
                    }                    
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("1 ");                        
                    }                    
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }



            while (TheGardenIsReady(garden))
            {
                if (garden.Processed[robot.PositionX,robot.PositionY+1] == 0 && garden.GardenBool[robot.PositionX, robot.PositionY + 1] != false)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    robot.PositionY++;
                    Console.BackgroundColor = ConsoleColor.Magenta;

                }
                else if (garden.Processed[robot.PositionX-1, robot.PositionY + 1] == 0 && garden.GardenBool[robot.PositionX-1, robot.PositionY + 1] != false)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    robot.PositionY++;
                    robot.PositionX--;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }

                else if (garden.Processed[robot.PositionX + 1, robot.PositionY + 1] == 0 && garden.GardenBool[robot.PositionX + 1, robot.PositionY + 1] != false)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    robot.PositionY++;
                    robot.PositionX++;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }




            }

            bool TheGardenIsReady(Garden garden)
            {
                bool isReady = false;
                for (int i = 0; i < garden.GardenSize.GetLength(0); i++)
                {
                    for (int j = 0; j < garden.GardenSize.GetLength(1); j++)
                    {

                        if (garden.Processed[i, j] == 0)
                        {
                            isReady= false;
                        }
                        else
                        {
                            isReady= true;
                        }
                    }
                }
                return isReady;
            }

           void RevealSurrounding(Robot robot, Garden garden)
            {

                if (garden.GardenBool[robot.PositionX-1,robot.PositionY-1] == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (garden.GardenBool[robot.PositionX - 1, robot.PositionY ] == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (garden.GardenBool[robot.PositionX - 1, robot.PositionY +1] == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

               

            }




            Console.ReadKey();
        }
    }
}
