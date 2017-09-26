using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_osob.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Birth_number { get; set; }
        public int Date_number { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Birth_number + " " + Date_number + " " + Gender;
        }
    }
}
