using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DidntFindMyClassAndMethod
{
    public class AssemblyWatcher
    {
        public static string ErrorMessage = "";

        public static Assembly GetAssemblyFromStringOrByteArr(object assemblyObj)
        {
            Assembly assembly = null;
            if (assemblyObj is string)
            {
                try
                {
                    assembly = GetAssembly((string)assemblyObj);
                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
            }
            return assembly;
        }

        public static Assembly GetAssembly(string assemblyPath)
        {
            string p = Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            string pp = Path.Combine(p,@"..\..\..\.." , assemblyPath);
            string newPath = pp;
            return Assembly.Load(File.ReadAllBytes(newPath));
        }

        public static Type[] GetTypes(Assembly assembly)
        {
            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                ErrorMessage = e.Message;
                types = e.Types.Where(t => t != null).ToArray();
            }
            return types;
        }

    }

}
