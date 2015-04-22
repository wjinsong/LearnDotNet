using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDotNet
{
    public interface iGreeting
    {
        void GreetingPeople(string name);
    }
    public class EnglishGreeting : iGreeting
    {
        public void GreetingPeople(string name)
        {
            Console.WriteLine("Morning " + name);

        }
    }

    public class ChineseGreeting : iGreeting
    {
        public void GreetingPeople(string name)
        {
            Console.WriteLine("早安 " + name);

        }
    }
}
