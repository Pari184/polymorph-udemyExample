using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_udemyExample
{
    class Person
    {
        private string fName;
        private string lName;
        private DateTime dob;
        private string g;
        private double w;
        private double h;

        public Person()
        {
            Console.WriteLine(" Person object being created w/out parameters");

        }
        public Person
            (
            string Firstname = "Not Specified",
            string Lastname = "Not Specified",
            DateTime Dateofbirth = default(DateTime),
            string Gender = "unknown",
            double Weight = -1,
            double Height = -1
            )
        {
            if (Firstname.Equals("Not Specified") || Lastname.Equals("Not Specified") || Dateofbirth == default(DateTime))
            {
                Console.WriteLine("Throwing an exception because the required field was null");
                Console.ReadLine();
                Console.WriteLine("First, Last and DOB may not be null.");

            }
            else
            {
                Console.WriteLine("Person object being created with parameters");
                fName = Firstname;
                lName = Lastname;
                dob = Dateofbirth;
                g = Gender;
                w = Weight;
                h = Height;
            }

        }
        public void setFirstName(string Firstname = "Not Specified")
        {
            if (Firstname == "Not Specified")
            {
                Console.WriteLine("Firstname cannot be null");
            }
            else
            {
                fName = Firstname;
            }
        }
        public void setLastName(string Lastname = "Not Specified")
        {
            if (Lastname == "Not Specified")
            {
                Console.WriteLine("Lastname cannot be null");
            }
            else
            {
                lName = Lastname;
            }
        }
        public void setDateofbirth(DateTime Dateofbirth = default(DateTime))
        {
            if (Dateofbirth == default(DateTime))
            {
                Console.WriteLine("Dateofbirth cannot be null");
            }
            else
            {
                dob = Dateofbirth;
            }
        }
        public void setGender(string Gender = "unknown")
        {
            g = Gender;
        }
        public void setHeight(double Height = -1)
        {
            h = Height;
        }
        public void setWeight(double Weight = -1)
        {
            w = Weight;
        }
        public string getFirstname()
        {
            return fName;
        }
        public string getLastname()
        {
            return lName;
        }
        public DateTime getDateofbirth()
        {
            return dob;
        }
        public string getGender()
        {
            return g;
        }
        public double getHeight()
        {
            return h;
        }
        public double getweight()
        {
            return w;
        }
        private bool isAFatty()
        {
            if (w / h > 2.25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FailsBMI()
        {
            if (w * h > 0)
            {
                return isAFatty();
            }
            else
            {
                return false;
            }
        }
    }
}
