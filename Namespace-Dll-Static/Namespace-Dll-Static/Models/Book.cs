using Namespace_Dll_Static.Helpers.Extensions;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static.Models
{
    public class Book
    {
        //public readonly int num = 5;
        public const int num = 5;
        public int result = 0;

        static Book()
        {
            //num = 100;
            int a = 5;
            //Console.WriteLine(a.PowerOfNums(2));
            Console.WriteLine(num);
        }

        //public Book()
        //{
        //    result = num + 66;
        //}

        //public Book()
        //{
        //    Id = 10;
        //}

    }
}
