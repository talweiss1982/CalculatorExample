%namespace MyCalculator
%partial
%parsertype MyParserParser
%visibility internal
%tokentype Token

%union { 
            public int i;
			public IntValueNode v; 
            public CalculatorAstBaseNode a;
			public string s; 
	   }

%start main

%token PLUS MINUS MUL DIV MOD P_OPEN P_CLOSE 
%token <i> NUMBER 
%type <a> term factor exp main
%type <v> number
%%

main   : exp                { Console.WriteLine("Parser: main -> exp; {0}", $1); $$ = $1; Expression = $1; };
exp : term                  { Console.WriteLine("Parser: exp -> term; {0}", $1); $$ = $1; }
    | exp PLUS term         { Console.WriteLine("Parser: exp -> exp PLUS term; {0}+{1}", $1,$3); $$ = new OperatorNode($1,OperatorNode.Operator.Plus,$3); }
    | exp MINUS term        { Console.WriteLine("Parser: exp -> exp MINUS term; {0}-{1}", $1,$3); $$ = new OperatorNode($1,OperatorNode.Operator.Minus,$3);}
    ;
term: factor                    { Console.WriteLine("Parser: term -> factor; {0} ", $1); $$ = $1; }
    | term DIV factor           { Console.WriteLine("Parser: term -> term DIV factor; {0}/{1} ", $1,$3); $$ = new OperatorNode($1,OperatorNode.Operator.Div,$3); }
    | term MOD factor           { Console.WriteLine("Parser: term -> term MOD factor; {0}%{1} ", $1,$3); $$ = new OperatorNode($1,OperatorNode.Operator.Mod,$3); }
    | term MUL factor           { Console.WriteLine("Parser: term -> term MUL factor; {0}*{1} ", $1,$3); $$ = new OperatorNode($1,OperatorNode.Operator.Mul,$3); }
    ;

factor:  number                 { Console.WriteLine("Parser: factor -> number; {0} ", $1); $$ = $1; }
        | P_OPEN exp P_CLOSE    { Console.WriteLine("Parser: P_OPEN exp P_CLOSE; ({0})", $2); $$ = new ParenthesisNode($2); }
         ;
number : 
       | NUMBER							{ Console.WriteLine("Parser: number -> NUMBER: {0}", $1); $$ = new IntValueNode($1);}
       ;

%%