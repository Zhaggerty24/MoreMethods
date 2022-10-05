using System;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Name();
            Age();
            Multiply();
        }
        static void Name()
        {
            string myName = "Zach";

            Console.WriteLine($" Hello my name is {myName}");
        }
        static void Age()
        {
            string myAge = "27";

            Console.WriteLine($" Nice to meet you I am {myAge} years old");
        }
        static void Multiply()
        {
            Console.WriteLine(2 *(4 + 6));
           
        }
    }
}