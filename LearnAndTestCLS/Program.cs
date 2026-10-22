#define KOKO
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
            testConditionalAttribute("This is a log message with conditional attribute.");
        }
    }
}
