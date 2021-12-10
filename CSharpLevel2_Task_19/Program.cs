/* 
 * Create new instance of Worker. Get instance type. Get property
 * FullName by name from type. Set property value to “Ivan
 * Draganov” using Reflection.
*/

using System;

namespace CSharpLevel2_Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var Worker = new { FirstName = "Alexandrina", LastName = "Varbanova", Age = 30 };

            Type worker = Worker.GetType();
            var propertyName = worker.GetProperty(worker.FullName);
            propertyName.SetValue(worker, "Ivan Draganov");
            Console.WriteLine(propertyName.ToString());
        }
    }
}
