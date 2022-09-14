/*
Author: John DiPasqua
Date: 9/13/2022
Description: C# console to get a series of odd or even numbers between 1 and 100 using iterative statements
*/


namespace Iterative_Statements_Deliverable_3
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("ENTER AN INTEGER BETWEEN 1 AND 100: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("'ODD' OR 'EVEN' SERIES?: ");
                string odd_or_even = Console.ReadLine();

                string prompt = $"You have selected the {odd_or_even} series. The numbers between 1 and {num} are:";

                if (num >= 1 & num <= 100)
                {
                    if (odd_or_even == "odd")
                    {
                        Console.WriteLine(prompt);
                        for (int i = 1; i <= num; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else if (odd_or_even == "even")
                    {
                        Console.WriteLine(prompt);
                        for (int i = 2; i <= num; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ENTER 'odd' or 'even'");
                    }
                }
                else
                {
                    Console.WriteLine("ENTER AN INTEGER BETWEEN 1 AND 100");
                }

            }
            catch
            {
                Console.WriteLine("ENTER CORRECT DATA TYPES.");
            }
        }
    }
}