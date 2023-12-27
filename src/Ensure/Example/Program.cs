using EnsureCore;
using EnsureCore.Extensions;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ensure.Is.NotNull("", "");

            try
            {
                object obj = null;
                Ensure.Is.NotNull(obj, "", "Value can not be null");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Exception occured.");
            }

            Console.WriteLine("Hello, World!");
        }
    }
}