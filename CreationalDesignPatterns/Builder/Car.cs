using System.Collections.Generic;
using System.Text;
using System;

namespace Builder
{
    public class Car
    {
        private List<string> _parts;

        public Car()
        {
            _parts = new List<string>();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void PrintCarParts()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Car elements:");
            foreach (var part in _parts)
                sb.AppendLine($"* {part}");
            Console.WriteLine(sb.ToString());
        }
    }
}