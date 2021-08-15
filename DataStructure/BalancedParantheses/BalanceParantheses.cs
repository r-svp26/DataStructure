using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BalancedParantheses
{
    public class BalanceParantheses
    {
        /// <summary>
        /// check expression is balanced or not
        /// </summary>
        /// <returns>true/false</returns>
        public static bool CheckParantheses()
        {
            bool rs;
            Stack<char> stack = new Stack<char>();
            string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('('))
                {
                    stack.Push(expression[i]);
                }
                else if (expression[i].Equals(')'))
                {
                    rs = stack.Pop();
                    if (rs == true)
                    {
                        break;
                    }
                }
            }
            if (stack.IsEmpty() == true)
                return true;
            return false;
        }
    }
}
