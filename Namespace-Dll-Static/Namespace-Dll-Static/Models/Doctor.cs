using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static.Models
{
    internal class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public int MyProperty { get; set; }

        //public Doctor()
        //{
        //    Id = 400;
        //}


        static Doctor()
        {
            Console.WriteLine("static constructor");
        }

        public Doctor()
        {
            Console.WriteLine("non-static constructor");
        }
    }
}
