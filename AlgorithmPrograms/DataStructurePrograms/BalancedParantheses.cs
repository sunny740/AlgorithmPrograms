using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.DataStructurePrograms
{
    public class BalancedParantheses<T>
    {
        public bool Parenthesis<T>()
        {
            char[] exp = { '(', '5', '+', '6', ')', '*', '(', '7', '+', '8', ')', '/', '(', '4', '+', '3', ')','(','5','+','6',')','*','(','7','+','8',')','/','(','4','+','3',')' };
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    stack.Push(exp[i]);
                }
                if (exp[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == -1)
            {
                Console.WriteLine("Balanced paranthesis");
                return true;
            }
            else
            {
                Console.WriteLine("Not Balanced");
                return false;
            }
        }
    }
}
