using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nästladeloopar
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //övning1
            int bredd = 5;
            int höjd = 10;

            for (int x = 0; x < höjd; x++)
            {
                for (int y = 0; y < bredd; y++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }

            //övning 2 
            double bredd = 5;
            int höjd = 11;

            for (int i = 0; i < höjd; i++)
            {
                for (int y = 0; y < bredd; y++)
                {
                    if (i%2 == 0)
                    {
                        Console.Write("o#" + );
                    }
                
                    else
                    {
                        Console.Write("#o");
                    }
                    
                }
                Console.WriteLine();
            } 
            
            //övning 3
            for (int x = 9; x > 0; x--)
            {
                for (int i = 0; i < x ; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine( " ");
            }
            Console.WriteLine(" "); */

            //övning 4
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(".");
                }
                for (int z = 0; z < 7-i; z++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
           
        }
    }
}
