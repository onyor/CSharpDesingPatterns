using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            string roma = "MCMXXVIII";
            Context context = new Context(roma);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression()); 
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}", roma, context.Output);
            Console.ReadKey();
        }
    }
}