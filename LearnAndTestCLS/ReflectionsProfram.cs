using System;
using System.Linq;
using System.Reflection;

namespace LearnAndTestCLS
{
    internal class ReflectionProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection example");
            Type type = typeof(BankAccount);

            Console.WriteLine("=== 1. Public Properties ===");

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (properties != null)
            {

                foreach (var prop in properties)
                {
                    Console.WriteLine($"Properties {prop.PropertyType} {prop.Name}");
                }
            }

            Console.WriteLine("\n=== 2. Private Field (Balance) ===");

            FieldInfo balanceField = type.GetField("Balance", BindingFlags.NonPublic | BindingFlags.Instance);
            if (balanceField != null)
            {
                Console.WriteLine($"Field Name: {balanceField.Name}, Type: {balanceField.FieldType}");
            }

            Console.WriteLine("\n=== 3. NonPublic Instance Methods ===");

            var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            if (privateMethods != null)
            {
                foreach (var method in privateMethods)
                {
                    var parameters = method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}");
                    string paramList = string.Join(", ", parameters);
                    Console.WriteLine($" private Method  : {method.Name} | Parameters : {paramList}");
                }
            }


            Console.ReadKey();
        }
    }
}