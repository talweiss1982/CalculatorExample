using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public abstract class CalculatorAstBaseNode
    {
        public abstract int Calculate();
    }

    public class SingleValueNode : CalculatorAstBaseNode
    {
        public CalculatorAstBaseNode Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }

        public override int Calculate()
        {
            return Value.Calculate();
        }
    }
    public class IntValueNode : CalculatorAstBaseNode
    {
        public IntValueNode(int val)
        {
            Value = val;
        }
        public int Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }

        public override int Calculate()
        {
            return Value;
        }
    }
    public class OperatorNode : CalculatorAstBaseNode
    {
        public OperatorNode(CalculatorAstBaseNode leftNode,Operator op , CalculatorAstBaseNode rightNode)
        {
            LeftNode = leftNode;
            RightNode = rightNode;
            Op = op;
        }
        public CalculatorAstBaseNode LeftNode { get; set; }
        public CalculatorAstBaseNode RightNode { get; set; }
        public Operator Op { get; set; }
        public override string ToString()
        {
            string op;
            switch (Op)
            {
                case Operator.Mul:
                    op = " * ";
                    break;
                case Operator.Div:
                    op = " / ";
                    break;
                case Operator.Mod:
                    op = " % ";
                    break;
                case Operator.Plus:
                    op = " + ";
                    break;
                case Operator.Minus:
                    op = " - ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return $"{LeftNode}{op}{RightNode}";
        }

        public override int Calculate()
        {
            switch (Op)
            {
                case Operator.Mul:
                    return LeftNode.Calculate()*RightNode.Calculate();
                case Operator.Div:
                    return LeftNode.Calculate() / RightNode.Calculate();
                case Operator.Mod:
                    return LeftNode.Calculate() % RightNode.Calculate();
                case Operator.Plus:
                    return LeftNode.Calculate() + RightNode.Calculate();
                case Operator.Minus:
                    return LeftNode.Calculate() - RightNode.Calculate();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public enum Operator
        {
            Mul,
            Div,
            Mod,
            Plus,
            Minus
        }
    }


    public class ParenthesisNode : CalculatorAstBaseNode
    {
        public ParenthesisNode(CalculatorAstBaseNode node)
        {
            Node = node;
        }
        public CalculatorAstBaseNode Node { get; set; }
        public override int Calculate()
        {
            return Node.Calculate();
        }
    }
}
