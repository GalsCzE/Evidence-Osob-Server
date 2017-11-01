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
        public string Birth_number { get; set; }
        public DateTime Date_number { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Birth_number + " " + Date_number + " " + Gender;
        }
    }
}
