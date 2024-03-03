
namespace Namespace_Dll_Static.Models
{
    internal class Teacher
    {
        public static int Count { get; set; }

        public Teacher()
        {
            Count++;
        }
    }
}
