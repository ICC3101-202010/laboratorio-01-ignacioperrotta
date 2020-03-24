using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio

{
    public class Person
    {
        public string name;
        public string lastname;
        public int lanzar()
        {
            Random p1 = new Random();
            int lanzar = p1.Next(3);
            return lanzar;
        }


        public Person()
        {
            this.name = "Bob";
            this.lastname = "Kunga";
        }
        public string Getname()
        {
            return name;
        }
        public string Getlastname()
        {
            return lastname;
        }

    }
}
