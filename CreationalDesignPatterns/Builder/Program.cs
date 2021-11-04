using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Build(builder);
            var car = builder.GetCar();
            car.PrintCarParts();
        }
    }
}
