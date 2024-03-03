//2 eded extension method yazirsiz.
//Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir.
//Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.

namespace Namespace_Dll_Static_Homework.Helpers.Extensions
{
    internal static class EmailExtension
    {
        public static bool IsValid(this string email)
        {
            return email.Contains('@');
        }

        public static bool CheckPasswordLength(this string password)
        {
            return password.Length > 8;
        }
    }
}
