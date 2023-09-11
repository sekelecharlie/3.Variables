using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string name;
            string surname;
            int age;

            //initialization
            name = "Charlie";
            age = 28;

            //printing to console
            Console.WriteLine("Hi "+name);
            Console.WriteLine("You are "+age);

            //change Variables

            name = "Thato";
            surname = "Sekele";
            age = 30;
            Console.WriteLine("He never liked his name, at age " + age + " he changed to " + name +" "+surname);
        }
    }
}
