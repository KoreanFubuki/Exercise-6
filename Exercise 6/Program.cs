using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Temperature?");
            string ttemp = Console.ReadLine();
            int temp;
            int.TryParse(ttemp, out temp);
            string answer;
            if (int.TryParse(ttemp, out temp))
            {
                answer = temp <= 15 ? "it is too cold here" : 16 <= temp && temp <= 28 ? "it is okay" : "it is hot here";
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();  
        }
    }
}