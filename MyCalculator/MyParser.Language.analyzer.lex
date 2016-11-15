%namespace MyCalculator
%scannertype MyParserScanner
%visibility internal
%tokentype Token

%option stack, minimize, parser, verbose, persistbuffer, noembedbuffers 

Eol             (\r\n?|\n)
NotWh           [^ \t\r\n]
Space           [ \t]
Number          [0-9]+

%{

%}

%%

/* Scanner body */

"+"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.PLUS;}
"-"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.MINUS;}
"*"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.MUL;}
"/"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.DIV;}
"%"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.MOD;}
"("             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.P_OPEN;}
")"             {Console.WriteLine("Scanner: {0}", yytext);return (int)Token.P_CLOSE;}
{Number}		{ Console.WriteLine("Scanner: {0}", yytext);		GetNumber(); return (int)Token.NUMBER; }
{Space}+		{ Console.WriteLine("Scanner: Space (Will be ignored)"); }


%%