using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace polymorph_udemyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingExperience[] myExp = new ProgrammingExperience[5];
            myExp[0] = new ProgrammingExperience();
            myExp[0].ProgrammingLanguage = "C#";
            myExp[0].YrStarted = 2010;

            myExp[1] = new ProgrammingExperience();
            myExp[1].ProgrammingLanguage = "Javascript";
            myExp[1].YrStarted = 2019;

            myExp[2] = new ProgrammingExperience();
            myExp[2].ProgrammingLanguage = "Python";
            myExp[2].YrStarted = 2020;

            myExp[3] = new ProgrammingExperience();
            myExp[3].ProgrammingLanguage = "SQL";
            myExp[3].YrStarted = 2006;

            Programmer myProg = new Programmer();
            DateTime myBday = new DateTime(1984, 4, 01);

            myProg.setFirstName ("Parimala");
            myProg.setLastName("Sellappan");
            myProg.setDateofbirth(myBday);

            Console.WriteLine();
            Console.WriteLine("{ 0} { 1} is a Programmer. ", myProg.getFirstname(), myProg.getLastname());
            Console.WriteLine();

            for(int i=0;i<myExp.Length;i++)
            {
                Console.WriteLine("Has been coding" + myExp[i].ProgrammingLanguage+"for approximately" + myExp[i].YearsExperience+" years.");
                if (myExp[i].YrEnded * myExp[i].YrStarted > 0)
                    Console.WriteLine("Began in " + myExp[i].YrStarted + "Ended in " + myExp[i].YrEnded);
                else if (myExp[i].YrStarted > 0)
                    Console.WriteLine("Began in " + myExp[i].YrStarted + "and not yet ended.");
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
