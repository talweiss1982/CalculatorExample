using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator
{
    internal partial class MyParserScanner
    {

        void GetNumber()
        {
            yylval.s = yytext;
            yylval.i = int.Parse(yytext);
        }

		public override void yyerror(string format, params object[] args)
		{
			base.yyerror(format, args);
			Console.WriteLine(format, args);
			Console.WriteLine();
		}
    }
}
