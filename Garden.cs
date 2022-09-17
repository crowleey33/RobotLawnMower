using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotLawnMower
{
    class Garden
    {
        public Garden()
        {            
            GardenSize = GenerateGardenSize();                 // generate garden dimensions
            GardenBool = UploadGardenWithContent(GardenSize);  // generates grass and trees
            Processed = GenerateProcessedMatrix(GardenSize);   // tracks how many times have the robot visited the actual coordinate
        }

        public bool[,] GardenSize { get; set; }
        public bool[,] GardenBool { get; set; }
        public int[,] Processed { get; set; }

        public static bool[,] GenerateGardenSize()
        {
            bool[,] gardenSize = new bool[GenerateRandom().Next(10, 20), GenerateRandom().Next(10, 20)];
            return gardenSize;
        }

        public static bool[,] UploadGardenWithContent(bool[,] gardenSize)
        {
            bool[,] gardenBool = new bool[gardenSize.GetLength(0), gardenSize.GetLength(1)];

            for (int i = 0; i < gardenBool.GetLength(0); i++)
            {
                for (int j = 0; j < gardenBool.GetLength(1); j++)
                {
                    if (GenerateRandom().Next(0, 100) <= 80)
                    {
                        gardenBool[i, j] = true;
                    }
                    else
                    {
                        gardenBool[i, j] = false;
                    }
                }
            }
            gardenBool[1, 1] = true;
            return gardenBool;
        }

        public static int[,] GenerateProcessedMatrix(bool[,] gardenSize)
        {
            int[,] processed = new int[gardenSize.GetLength(0), gardenSize.GetLength(1)];
            
            for (int i = 0; i < gardenSize.GetLength(0); i++)
            {
                for (int j = 0; j < gardenSize.GetLength(1); j++)
                {
                    processed[i, j] = 0; 
                }
            }
            return processed;
        }

        public static Random GenerateRandom()
        {
            return new Random();
        }
    }



}
