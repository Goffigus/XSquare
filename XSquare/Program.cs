using System;

using static System.Console;

namespace XSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            //nested for loops
            //Each iteration prints 2 alternating rows so only run 5 times to have 10 x 10 squarish thing
            for (int i = 0; i < 5; i++) 
                WriteLine("");
                WriteLine("");
                for(int g = 0; g < 5; g++) //Prints off a row of X's and O's
                {
                    Write("\tX");
                    Write("\tO");
                }
                WriteLine("");
                WriteLine("");
                
                //Prints off a row of O's and X's so it alternates with the row above
                for (int g = 0; g < 5; g++) 
                {
                    Write("\tO");
                    Write("\tX");
                }
                
            }
        }
    }
}
