using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McFit_Kundenkartei
{
    [Serializable()]
    class Person
    {
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string Lastname
            {
            get { return lastname; }
            set { lastname = value; }
        }
        private string dateOfBirth;
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        // Konstruktoren
        public Person(string fn, string ln, string dob)
        {
            this.firstname = fn;
            this.lastname = ln;
            this.DateOfBirth = dob;
        }


        public Person()
        {

        }        
    }
}
