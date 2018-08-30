using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson1();
            Lesson2();
            TryCatchFinallyExample();
        } // Main method

        // Lesson 1 - memory management
        //  see also, variablescopes.cs
        private static void Lesson1()
        {
            // Variable declaration
            string name;
            int i;
            DateTime today;

            // Variable initialisation
            name = "Chris";
            i = 5;
            today = DateTime.Now;

            // declaration and initialisation in one line
            double d = Math.PI;

        } // Lesson 1 method
        // Lesson 1 - see also, variablescopes.cs

        // Lesson 2 -- control of flow
        private static void Lesson2()
        {
            // if, else if, and else example
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                Console.WriteLine("Today is Saturday");
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Today is Sunday");
            else
                Console.WriteLine("Today is a weekday!");

            // switch example
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    // This code will not run because of 
                    //  the DayOfWeek enum
                    Console.WriteLine("Today does not exist!");
                    break;
            }  // switch

            // switch example for multiple switch case labels
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It is the weekend");
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Friday:
                    Console.WriteLine(
                        "Today is the beginning or end of the week");
                    break;
                default:
                    // This code will not run because of 
                    //  the DayOfWeek enum
                    Console.WriteLine("Today is a weekday");
                    break;
            }  // switch 

            // for example
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            } // for

            // foreach example
            int[] array = new int[10]
               { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            } // foreach

            // do example
            int k = 0;
            sum = 0;
            do
            {
                sum += array[k];
                k++;
            } while (k < array.Length);

            // while example
            k = 0;
            sum = 0;
            while (k < array.Length)
            {
                sum += array[k];
                k++;
            } // while

            // break example
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                // stop the loop when 7 is reached
                if (i == 7) break;
            } // for

            // continue example
            for (int i = 0; i < 10; i++)
            {
                // only process odd numbers
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            } // for

            // goto example
            for (int i = 0; i < 10; i++)
            {
                // process number 7 differently
                if (i == 7) goto seven;
                Console.WriteLine(i);
                continue;
                seven:
                {
                    Console.WriteLine("This is number 7!");
                } // seven named block
            } // for


        } // Lesson 2

        // lesson 2 return keyword example
        static void ReturnExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                // arbitrarily exit loop on 8th iteration
                if (i == 7) return;
            } // for
        }  // ReturnExample method

        // lesson 2 throw keyword example
        static void ThrowExample(int age)
        {
            // validate age input
            if (age < 0) throw new ArgumentException("Invalid age!");

            // TODO: add logic for processing age

        } // ThrowExample method

        static void TryCatchFinallyExample()
        {
            try
            {
                string s;
                FileInfo file = new FileInfo("aTextFile.txt");
                StreamReader sr = file.OpenText();
                try
                {
                    s = sr.ReadToEnd();
                    Console.WriteLine(s);
                } // try
                catch (Exception ex)
                {
                    Console.WriteLine(
                        "Error reading file\n{0}"
                        , ex.Message);
                } // catch
                finally
                {
                    if (sr != null)
                    {
                        sr.BaseStream.Close();
                        sr.Close();
                    } // if
                } // finally
            } // try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } // catch
        } // TryCatchFinallyExample method

    } // Program class
} //  namespace
