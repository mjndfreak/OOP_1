using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Person
    {
        
        public string name;
        public string surname;
        public string birthDate;
        public string profession;


        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                if (name != string.Empty)
                { 
                    name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (surname != string.Empty)
                {
                    surname = value;
                }
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (birthDate != string.Empty)
                {
                    birthDate = value;
                }
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                if (profession != string.Empty)
                {
                    profession = value;
                }
            }
        }

        public void DisplayPerson()
        {
            Console.WriteLine(@"
            Name: " + name + " Surname: " + surname + " Birth date: " + birthDate + " Profession: " + profession + "");
        }
    }
}
