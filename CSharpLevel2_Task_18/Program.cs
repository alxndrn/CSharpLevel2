/*
 * Get executing assembly. Get all types in executing assembly. In
 * loop: for types where namespace starts with "Work" - output
 * types’ names, one per line.
 * Hint: Watch out, namespace can be null. 
*/

using System;
using System.Reflection;

namespace CSharpLevel2_Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var Worker = new { FirstName = "Alexandrina", LastName = "Varbanova", Age = 30 };

            Type worker = Worker.GetType();
            string name = worker.Name;
            string namespace_ = worker.Namespace;
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                try
                {
                    if (namespace_.StartsWith("Work"))
                    {
                        Console.WriteLine(type.FullName);
                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }
        }
    }
}
