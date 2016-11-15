using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new MyParserParser();
            parser.Parse("1+3*2-7%5");
            Console.WriteLine($"The result is: {parser.Expression} = {parser.Expression.Calculate()}");
        }
    }
}
