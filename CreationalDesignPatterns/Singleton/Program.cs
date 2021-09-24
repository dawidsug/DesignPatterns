using System;

namespace CreationalDesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = Singleton.Instance();
            var secondInstance = Singleton.Instance();
            if(firstInstance.Equals(secondInstance))
            Console.WriteLine("Two created instances of Singleton class are the same instance");
            else Console.WriteLine("Or maybe no!");
        }
    }
}
