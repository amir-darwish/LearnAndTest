using Microsoft.Win32;
using System;


namespace LearnAndTestCLS.Registryy
{
    public class clsRegistry
    {
        static public bool Write(string Path, string Name, string Value)
        {
            try
            {
                Registry.SetValue(Path, Name, Value, RegistryValueKind.String);
                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine($"error : {e}"); ;
                return false;
            }


        }

        static public string Read(string Path, string ValueName) 
        {
            try
            {
                return Registry.GetValue(Path, ValueName, null) as string;
            }
            catch { return null; }
        }
    }
}
