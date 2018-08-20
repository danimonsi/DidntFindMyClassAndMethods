using System;
using System.Linq;

namespace DidntFindMyClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Check();
            Console.ReadKey();
        }

        private static void Check()
        {
            var assemblyStr = @".\ThisIsMyLib\bin\Debug\netstandard2.0\ThisIsMyLib.dll";
            var allTypes = AssemblyWatcher.GetTypes(AssemblyWatcher.GetAssemblyFromStringOrByteArr(assemblyStr)).ToList();
            Console.WriteLine(allTypes.Count);
            allTypes.ForEach(t => Console.WriteLine(t.FullName));
            Console.WriteLine(AssemblyWatcher.ErrorMessage);
        }
    }
}
