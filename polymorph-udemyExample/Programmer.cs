using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_udemyExample
{
    class Programmer:Person
    {
        ProgrammingExperience[] exp;
        public Programmer()
        {
            Console.WriteLine(" Programmer object being created w/out data properties");
        }
        public Programmer
            (
            ProgrammingExperience[] progExperience,
            string Firstname = "Not Specified",
            string Lastname = "Not Specified",
            DateTime Dateofbirth = default(DateTime),
            string Gender = "unknown",
            double Weight = -1,
            double Height = -1):base(Firstname,Lastname,Dateofbirth,Gender,Weight,Height)
        {
            Console.WriteLine("Programmer object being created with parameters");
            exp = progExperience;
        }
        public void setExperience(ProgrammingExperience[] prExp)
        {
            exp = prExp;

        }

        public ProgrammingExperience[] getExperience()
        {
            return exp;
        }
    
    }
}
