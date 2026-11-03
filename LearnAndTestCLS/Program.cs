#define KOKO
using LearnAndTestCLS.Registryy;
using System;
using System.Diagnostics;
using System.IO;

namespace LearnAndTestCLS
{
    public class Program
    {
        static public void LogToConsole(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        static public void LogToFile(string message)
        {
            // Logic to log the message to a file can be added here
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Log: {message}");
            }
        }
        static public void LogToDatabase(string message)
        {
            // Logic to log the message to a database can be added here
            Console.WriteLine($"Log to Database: {message}");
        }

        [Conditional("KOKO")]
        static public void testConditionalAttribute(string message)
        {
            // This method is marked with the Conditional attribute, so it will only be called if the "DEBUG" symbol is defined.
            LogToConsole("This log message will only appear in koko builds.");
        }

        static void Main(string[] args)
        {


            // with action delegate
            //Action<string> logToConsoleAction = LogToConsole;
            //Action<string> logToFileAction = LogToFile;
            //Action<string> logToDatabaseAction = LogToDatabase;

            //logToConsoleAction("This is a log message to the console.");
            //logToFileAction("This is a log message to the file.");
            //logToDatabaseAction("This is a log message to the database.");

            // test conditional attribute
            //testConditionalAttribute("This is a log message with conditional attribute.");

            //var i = Activator.CreateInstance(typeof(int));
            //i = 42; // Assign a value to the created instance

            //Console.WriteLine($"Created instance of int: {i}");
            //Console.WriteLine($"Type of instance: {i.GetType()}");

            // reflection example
            //Type type = typeof(string);
            //Console.WriteLine($"Type of string: {type}");
            //Console.WriteLine($"Name of string type: {type.Name}");
            //Console.WriteLine($"Full name of string type: {type.FullName}");
            //Console.WriteLine($"get inerface length: {type.GetInterfaces().Length}");

            //foreach (var iface in type.GetInterfaces())
            //{
            //    Console.WriteLine($"Interface: {iface}");
            //}

            // reflection example with BankAccount class
            //Assembly mscorlib = typeof(BankAccount).Assembly;

            //Type typeBank = mscorlib.GetType("BankAccount").GetType();

            //if (typeBank != null)
            //{
            //    Console.WriteLine($"Methods public of BankAccount Class :\n\n");
            //    var publicMethod = typeBank.GetMethods(BindingFlags.Public | BindingFlags.Instance)
            //        .OrderBy(method => method.Name);

            //    foreach (var method in publicMethod)
            //    {
            //        Console.WriteLine($"name of methods : {method.Name} \n");
            //        Console.WriteLine($"type of methods : {method.ReturnType} \n");
            //    }


            //}
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyFirstSoftware";
            string valueName = "YourValueName";
            string valueData = "YourValueData";

            //if (clsRegistry.Write(keyPath, valueName, valueData))
            //{
            //    Console.WriteLine("Success !\n\n");

            //}

            if (clsRegistry.Read(keyPath, valueName) != null)
            {
                Console.WriteLine($"The value of {valueName} is: {valueData}");
            }

            Console.ReadKey();


        }
    }
}
