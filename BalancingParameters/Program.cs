using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingParameters
{
    class Program
    {

        /*
         1) Declare a character stack S.
2) Now traverse the expression string exp.
    a) If the current character is a starting bracket (‘(‘ or ‘{‘ or ‘[‘) then push it to stack.
    b) If the current character is a closing bracket (‘)’ or ‘}’ or ‘]’) then pop from stack and if the popped character is the matching starting bracket then fine else parenthesis are not balanced.
3) After complete traversal, if there is some starting bracket left in stack then “not balanced”
             */
        static void Main(string[] args)
        {
          
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                var k =   chkexpression(expression);
                Console.WriteLine(k == true ? "YES" : "NO");

            }
        }

        static bool chkexpression(string texpression)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (char expression in texpression)
            {
                if ((expression == '{') || (expression == '(') || (expression == '['))
                {
                    myStack.Push(expression);
                }
                if ((expression == '}') || (expression == ')') || (expression == ']'))
                {

                    if (myStack.Count == 0)
                    {
                        return false;
                    }
                    bool h = false;
                    var k = myStack.Pop();
                    if ((k == '{') && (expression == '}'))
                    {
                        h = true;
                    }
                    if ((k == '(') && (expression == ')'))
                    {
                        h = true;
                    }
                    if ((k == '[') && (expression == ']'))
                    {
                        h = true;
                    }

                    if (!h)
                        return false;
                }
            }

            if (myStack.Count == 0)
                return true;
            


        }
 

    }
}
