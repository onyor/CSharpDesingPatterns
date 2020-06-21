using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationMultiply());
            Console.WriteLine(context.executeStrategy(5, 4));

            context = new Context(new OperationSubstract());
            Console.WriteLine(context.executeStrategy(5, 4));

            context = new Context(new OperationAdd());
            Console.WriteLine(context.executeStrategy(5, 4));
        }
    }
}
