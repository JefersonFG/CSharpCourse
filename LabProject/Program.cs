using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool colorX = true;
            char firstColor;
            char secondColor;

            for (int x = 0; x < 8; x++)
            {
                if (colorX)
                {
                    firstColor = 'X';
                    secondColor = 'O';
                }
                else
                {
                    firstColor = 'O';
                    secondColor = 'X';
                }

                colorX = !colorX;

                for (int y = 0; y < 8; y++)
                {
                    if (y % 2 == 0)
                    {
                        Console.Write(firstColor);
                    }
                    else
                    {
                        if (y == 7)
                        {
                            Console.WriteLine(secondColor);
                        }
                        else
                        {
                            Console.Write(secondColor);
                        }
                    }
                }
            }

            Console.ReadLine(); //Just so the window doesn't automatically close after execution
        }
    }
}
