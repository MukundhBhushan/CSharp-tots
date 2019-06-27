using System;
using System.Reflection;

namespace cSharpBasic
{
    class baseClass
    {
        static void Main(string[] args)
        {
            Type type = typeof(System.String);
            System.Console.WriteLine(type.name);
            System.Console.WriteLine(type.FullName);
            System.Console.WriteLine(type.IsClass);
            System.Console.WriteLine(type.IsGenericType);

            System.Console.ReadKey();
        }

    }
}