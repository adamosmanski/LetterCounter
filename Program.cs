using System;
using System.Linq;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var Get_Text = Console.ReadLine();
            
            foreach(var value in Get_Text)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
