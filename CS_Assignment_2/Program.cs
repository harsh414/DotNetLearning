using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare an array and insert data into the array by accepting data from user
            Console.WriteLine("Enter count of numbers to put in array");
            int cnt = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine("Enter value for " + i + "th index");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Resultant array is");
            Console.WriteLine();
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine("value at " + i + "th index is " + arr[i]);
            }

            //Dynamically search data from array by accepting record to search from user
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dynamically search data from array by accepting record to search from user");
            Console.WriteLine("Enter count of numbers for searching operations");
            int cnt2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[cnt2];
            for (int i = 0; i < cnt2; i++)
            {
                Console.WriteLine("Enter value for " + i + "th index");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter data to search");
            Console.WriteLine("Data searched is present in array at " +
                Array.IndexOf(arr2, Convert.ToInt32(Console.ReadLine())) + "th index");




            //Perform Following operations on these paragraphs
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Perform Following operations on these paragraphs");

            string str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny." +
                "The character—also known by the code number 007 (pronounced double-O - seven)—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
            Console.WriteLine("enter y or Y to process james bond string");
            string canContinue = "y";
            do
            {
                Console.WriteLine("1. Find out count of blanck spaces in the string");
                Console.WriteLine("2. Find out count of words in the string");
                Console.WriteLine("3. Find out count of statements in the string");
                Console.WriteLine("4. No of occurences of word in a string");
                Console.WriteLine("5. Find out count of vovels (a,e,i,o,u) in the string");
                Console.WriteLine("6. Convert first character of each word in string into the uppercase");
                Console.WriteLine("7. Print all special characters from the string.");
                Console.WriteLine("Enter the Option");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("No of blanck spaces in the string are = "+ CountIndividual(str,' '));
                        break;
                    case 2:
                        int words = CountIndividual(str, ' ') + Convert.ToInt32("1");
                        Console.WriteLine("count of words in the string are = " + words);
                        break;
                    case 3:
                        Console.WriteLine("No of statements in the string are = " + CountIndividual(str, '.'));
                        break;
                    case 4:
                        Console.WriteLine("Enter the world whose frequency has to be found:");
                        Console.WriteLine("Count of occurences of the " +
                            "entered world are = " + Occurences(str,Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("Count of vowels are: ");
                        Console.WriteLine();
                        Console.WriteLine("a and A :" + CountIndividual(str,'a') + CountIndividual(str,'A'));
                        Console.WriteLine("e and E :" + CountIndividual(str,'e') + CountIndividual(str,'E'));
                        Console.WriteLine("i and I :" + CountIndividual(str,'i') + CountIndividual(str,'I'));
                        Console.WriteLine("o and O :" + CountIndividual(str,'o') + CountIndividual(str,'O'));
                        Console.WriteLine("u and U :" + CountIndividual(str,'u') + CountIndividual(str,'U'));
                        break;
                    case 6:
                        Console.WriteLine(CapitalizeFirstLetter(str));
                        break;
                    case 7:
                        SpecialChar(str);
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Enter y or Y to continue");
                canContinue = Console.ReadLine();
                Console.Clear(); // Clearing the Screen
            } while (canContinue == "y" || canContinue == "Y");
            

            
            Console.Clear();
            Console.WriteLine("Declared an ArrayList and added integers, characters, string, decimal, etc. values in it");
            var originalList = UsingArrayList();
            Console.WriteLine("Choose and press a option");
            string check = "y";
            do
            {
                Console.WriteLine("1. Add Record in specific index of the ArrayList");
                Console.WriteLine("2. Remove Record at a specific Index");
                Console.WriteLine("3. Read only strings from the collection");

                int entered = Convert.ToInt32(Console.ReadLine());
                switch (entered)
                {
                    case 1:
                        Console.WriteLine("Enter value to Add");
                        var value = Console.ReadLine();
                        originalList.Add(value);
                        Console.WriteLine("Value Added");
                        break;

                    case 2:
                        Console.WriteLine("Enter index at which u want to remove value");
                        int idxx = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The elements in ArrayList initially are :");
                        foreach (var val in originalList)
                            Console.WriteLine(val);
                        originalList.RemoveAt(idxx);
                        Console.WriteLine("The elements in ArrayList after removal are :");

                        foreach (var val in originalList)
                            Console.WriteLine(val);
                        break;

                    case 3:
                        Console.WriteLine("String in arraylist are");
                        PrintStringsInArrayList(originalList);
                        break;
                    default:
                        break;
                }

            } while(check== "y" || check == "Y");

        }

        static int CountIndividual(string str, char s)
        {
            int blank = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == s)
                {
                    blank++;
                }
            }
            return blank;
        }

        static int Occurences(string str, string word)
        {
            string[] arr = str.Split(' ');
            int count = 0;
            
            /*for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == word)
                    count++;
            }*/
            foreach(string s in arr)
            {
                if (word.Equals(s))
                {
                    count++;
                }
            }
            return count;
        }

        static string CapitalizeFirstLetter(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        static void SpecialChar(string str)
        {
            string ans = " ";
            int count = 0;
            foreach (char c in str)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_'))
                {
                    ans += c;
                    count += 1;
                }
            }
            Console.WriteLine("all special characters are : " + ans);
            Console.WriteLine("Total special characters are : " + count);
        }

        static ArrayList UsingArrayList()
        {
            var array = new ArrayList();
            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add("Harsh");
            array.Add("Agarwal");
       
            array.Add(10.20);
            array.Add(20.30);
            array.Add(30.40);
            array.Add('A');
            array.Add('B');
            array.Add('C');
            array.Add('D');
            return array;
            
        }

        static void PrintStringsInArrayList(ArrayList arr)
        {
            Console.WriteLine("Strings only are");
            foreach (object obj in arr)
            {
                if(obj.GetType()== typeof(string))
                {
                    Console.WriteLine("Value = " + obj);
                }
            }
        }


    }

}