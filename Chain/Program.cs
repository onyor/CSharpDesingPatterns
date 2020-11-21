using System;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer();
            ProgramManager programManager = new ProgramManager();
            HR hr = new HR();

            //workflow u olusturuyoruz
            engineer.NextApprover = programManager;
            programManager.NextApprover = hr;

            engineer.ApplyLeave(3);

            Console.ReadLine();
        }
    }
}
