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
            
            //GreetingPeople("Zhang", new EnglishGreeting());
            //GreetingPeople("Zhang", new ChineseGreeting());

            List<int> list = new List<int> { 1, 2, 3,4,5,6 };

            IEnumerable<int> query = list.Where(  x => x % 2 == 0);

            Console.WriteLine(query.ToString());

            
            Console.ReadKey();
        }
        private static void GreetingPeople(string name, iGreeting makeGreeting)
        {
            makeGreeting.GreetingPeople(name);

        }

    }
    
}
