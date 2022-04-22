using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public class Person
    {
        
        private string fname;
        private string lname;
        private System.DateTime bdate;

        public Person (string FirstName, string LastName, DateTime BDate)
        {
            fname = FirstName;
            lname = LastName;
            bdate = BDate;
        }
        
        public Person()
        {
            fname = "Андрей";
            lname = "Ащеулов";
            bdate = new DateTime(2013, 12, 1);
        }

        public string Fname
        {
            get
            {
                return fname;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
        }

        DateTime BDate 
        {
            get
            {
                return bdate;
            }
           

        }
        int intBdate
        {
            get
            {
                return Convert.ToInt32(bdate);
            }
            set
            {
                bdate = Convert.ToDateTime(value);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nDate of birth: {2:dd.MM.yyyy}", fname, lname, BDate);
        }



        public string ToShortString()
        {
            return $"\n Имя: {fname} \n Фамилия: {lname}";
        }




    }
}
