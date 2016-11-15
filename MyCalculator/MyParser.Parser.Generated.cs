// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  TAL-PC
// DateTime: 11/15/2016 6:45:40 PM
// UserName: Tal
// Input file <MyParser.Language.grammar.y - 11/15/2016 6:43:57 PM>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace MyCalculator
{
internal enum Token {error=2,EOF=3,PLUS=4,MINUS=5,MUL=6,
    DIV=7,MOD=8,P_OPEN=9,P_CLOSE=10,NUMBER=11};

internal partial struct ValueType
{ 
            public int i;
			public IntValueNode v; 
            public CalculatorAstBaseNode a;
			public string s; 
	   }
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class MyParserParser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[14];
  private static State[] states = new State[21];
  private static string[] nonTerms = new string[] {
      "main", "term", "factor", "exp", "number", "$accept", };

  static MyParserParser() {
    states[0] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12},new int[]{-1,1,-4,3,-2,20,-3,19,-5,8});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{4,4,5,13,3,-2});
    states[4] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12,10,-12},new int[]{-2,5,-3,19,-5,8});
    states[5] = new State(new int[]{7,6,8,15,6,17,4,-4,5,-4,3,-4,10,-4});
    states[6] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12,10,-12},new int[]{-3,7,-5,8});
    states[7] = new State(-7);
    states[8] = new State(-10);
    states[9] = new State(-13);
    states[10] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,10,-12,4,-12,5,-12},new int[]{-4,11,-2,20,-3,19,-5,8});
    states[11] = new State(new int[]{10,12,4,4,5,13});
    states[12] = new State(-11);
    states[13] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12,10,-12},new int[]{-2,14,-3,19,-5,8});
    states[14] = new State(new int[]{7,6,8,15,6,17,4,-5,5,-5,3,-5,10,-5});
    states[15] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12,10,-12},new int[]{-3,16,-5,8});
    states[16] = new State(-8);
    states[17] = new State(new int[]{11,9,9,10,7,-12,8,-12,6,-12,4,-12,5,-12,3,-12,10,-12},new int[]{-3,18,-5,8});
    states[18] = new State(-9);
    states[19] = new State(-6);
    states[20] = new State(new int[]{7,6,8,15,6,17,4,-3,5,-3,3,-3,10,-3});

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-6, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-4});
    rules[3] = new Rule(-4, new int[]{-2});
    rules[4] = new Rule(-4, new int[]{-4,4,-2});
    rules[5] = new Rule(-4, new int[]{-4,5,-2});
    rules[6] = new Rule(-2, new int[]{-3});
    rules[7] = new Rule(-2, new int[]{-2,7,-3});
    rules[8] = new Rule(-2, new int[]{-2,8,-3});
    rules[9] = new Rule(-2, new int[]{-2,6,-3});
    rules[10] = new Rule(-3, new int[]{-5});
    rules[11] = new Rule(-3, new int[]{9,-4,10});
    rules[12] = new Rule(-5, new int[]{});
    rules[13] = new Rule(-5, new int[]{11});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // main -> exp
{ Console.WriteLine("Parser: main -> exp; {0}", ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = ValueStack[ValueStack.Depth-1].a; Expression = ValueStack[ValueStack.Depth-1].a; }
        break;
      case 3: // exp -> term
{ Console.WriteLine("Parser: exp -> term; {0}", ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = ValueStack[ValueStack.Depth-1].a; }
        break;
      case 4: // exp -> exp, PLUS, term
{ Console.WriteLine("Parser: exp -> exp PLUS term; {0}+{1}", ValueStack[ValueStack.Depth-3].a,ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = new OperatorNode(ValueStack[ValueStack.Depth-3].a,OperatorNode.Operator.Plus,ValueStack[ValueStack.Depth-1].a); }
        break;
      case 5: // exp -> exp, MINUS, term
{ Console.WriteLine("Parser: exp -> exp MINUS term; {0}-{1}", ValueStack[ValueStack.Depth-3].a,ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = new OperatorNode(ValueStack[ValueStack.Depth-3].a,OperatorNode.Operator.Minus,ValueStack[ValueStack.Depth-1].a);}
        break;
      case 6: // term -> factor
{ Console.WriteLine("Parser: term -> factor; {0} ", ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = ValueStack[ValueStack.Depth-1].a; }
        break;
      case 7: // term -> term, DIV, factor
{ Console.WriteLine("Parser: term -> term DIV factor; {0}/{1} ", ValueStack[ValueStack.Depth-3].a,ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = new OperatorNode(ValueStack[ValueStack.Depth-3].a,OperatorNode.Operator.Div,ValueStack[ValueStack.Depth-1].a); }
        break;
      case 8: // term -> term, MOD, factor
{ Console.WriteLine("Parser: term -> term MOD factor; {0}%{1} ", ValueStack[ValueStack.Depth-3].a,ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = new OperatorNode(ValueStack[ValueStack.Depth-3].a,OperatorNode.Operator.Mod,ValueStack[ValueStack.Depth-1].a); }
        break;
      case 9: // term -> term, MUL, factor
{ Console.WriteLine("Parser: term -> term MUL factor; {0}*{1} ", ValueStack[ValueStack.Depth-3].a,ValueStack[ValueStack.Depth-1].a); CurrentSemanticValue.a = new OperatorNode(ValueStack[ValueStack.Depth-3].a,OperatorNode.Operator.Mul,ValueStack[ValueStack.Depth-1].a); }
        break;
      case 10: // factor -> number
{ Console.WriteLine("Parser: factor -> number; {0} ", ValueStack[ValueStack.Depth-1].v); CurrentSemanticValue.a = ValueStack[ValueStack.Depth-1].v; }
        break;
      case 11: // factor -> P_OPEN, exp, P_CLOSE
{ Console.WriteLine("Parser: P_OPEN exp P_CLOSE; ({0})", ValueStack[ValueStack.Depth-2].a); CurrentSemanticValue.a = new ParenthesisNode(ValueStack[ValueStack.Depth-2].a); }
        break;
      case 13: // number -> NUMBER
{ Console.WriteLine("Parser: number -> NUMBER: {0}", ValueStack[ValueStack.Depth-1].i); CurrentSemanticValue.v = new IntValueNode(ValueStack[ValueStack.Depth-1].i);}
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
