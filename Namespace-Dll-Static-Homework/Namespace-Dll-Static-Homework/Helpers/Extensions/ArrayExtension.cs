
namespace Namespace_Dll_Static_Homework.Helpers.Extensions
{
    internal static class ArrayExtension
    {
        public static int ProductOfElems(this int[] numbers)
        {
            int product = 1;

            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}
