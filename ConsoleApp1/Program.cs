using Microsoft.Win32;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

            string[] valueNames = subKeyNames.GetValueNames();
            foreach (var item in valueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}