using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Types_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Thor is a 2011 American superhero film based" +
                " on the Marvel Comics character of the same name. Produced by" +
                " Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel " +
                "Cinematic Universe (MCU). It was directed by Kenneth Branagh," +
                " written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth " +
                "as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, " +
                "Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo," +
                " and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped" +
                " of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) " +
                "plots to take the Asgardian throne, Thor must prove himself worthy.";

            int idxOfA=  str.LastIndexOf('a');
            Console.WriteLine("Index of a is " + idxOfA);
            int idxOfE=  str.LastIndexOf('e');
            Console.WriteLine("Index of e is " + idxOfE);
            int idxOfI= str.LastIndexOf('i');
            Console.WriteLine("Index of i is " + idxOfI);
            int idxOfO =  str.LastIndexOf('o');
            Console.WriteLine("Index of o is " + idxOfO);
            int idxOfU=  str.LastIndexOf('u');
            Console.WriteLine("Index of u is " + idxOfU);

            // task2
            int cntOfand = occurences(str, "and");
            Console.WriteLine("Count Of And is " + cntOfand);


             
            //task3---> ensuring positive input x and y
            int x, y;
            Console.WriteLine("Enter x");
            while (true)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x <= 0)
                {
                  
                    Console.WriteLine("Enter positive x");
                    continue;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Enter y");
            while (true)
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (y <= 0)
                {
               
                    Console.WriteLine("Enter postive y");
                    continue;
                }
                else
                {
                    break;
                }

            }



            // task4---> operations
            Console.WriteLine("Square of x = " + squareOf(x));
            Console.WriteLine("Power of x to y is = " + raiseToPower(x,y));



        }






        static int raiseToPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else if (y % 2 == 0)
                return raiseToPower(x, y / 2) * raiseToPower(x, y / 2);
            else
                return x * raiseToPower(x, y / 2) * raiseToPower(x, y / 2);
        }
        static int squareOf(int x)
        {
            return x * x;
        }

        static int occurences(string str, string word)
        {
            string[] arr = str.Split(' ');
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (word.Equals(arr[i]))
                    count++;
            }

            return count;
        }
       
    }
}
