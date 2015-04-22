using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingPeople("Zhang", new EnglishGreeting());
            GreetingPeople("Zhang", new ChineseGreeting());
            Console.ReadKey();
        }
        private static void GreetingPeople(string name, iGreeting makeGreeting)
        {
            makeGreeting.GreetingPeople(name);

        }

    }
    
}
