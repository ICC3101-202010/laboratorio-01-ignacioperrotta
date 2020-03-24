using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine(p.lanzar());
            Person p2 = new Person();
            Console.WriteLine(p2.Getname() + " " + p2.Getlastname());
        }
    }
}