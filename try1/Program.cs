using System;
using System.Collections.Generic;

namespace try1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> gameWorldMementos = new List<String>();

            gameWorldMementos.Add("onur");
            gameWorldMementos.Add("secil");
            gameWorldMementos.Add("ahmet");
            gameWorldMementos.Add("remzi");
            gameWorldMementos.Add("hakkı");
            gameWorldMementos.Add("hakkı323");

            string merhaba= gameWorldMementos[gameWorldMementos.Count - 3];

            Console.WriteLine(merhaba);

            Console.ReadKey();


        }
    }
}
