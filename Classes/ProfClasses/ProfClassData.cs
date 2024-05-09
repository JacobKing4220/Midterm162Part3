using System;

namespace ProfessorClasses
{
    public class Professor   {



        private string Lnum;
        private string firstName;
        private string lastName;
        private string dept;

        public Professor() { }

        public Professor(string profLnum, string profFName, string profLName, string profDept)
        {
            Lnum = profLum;
            firstName = profFName;
            lastName = profLName;
            dept = profDept;
            
        }


        public string ProfLnum
        {
            get
            {
                return Lnum;
            }
            set
            {
                Lnum = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Dept
        {
            get
            {
                return dept;
            }
            set
            {
                dept = value;
            }
        }

        public override string ToString()
        {
            // to change
            return String.Format("Lnumber: {0} First Name: {1} Last Name: {2} Dept: {3} " id, firstName, lastName, dept);
        }

    }
}
