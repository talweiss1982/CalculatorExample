using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyCalculator
{
    internal partial class MyParserParser
    {
        public MyParserParser() : base(null) { }
        public CalculatorAstBaseNode Expression { get; private set; }
        public void Parse(string s)
        {
            byte[] inputBuffer = System.Text.Encoding.Default.GetBytes(s);
            MemoryStream stream = new MemoryStream(inputBuffer);
            this.Scanner = new MyParserScanner(stream);
            this.Parse();
        }
    }
}
