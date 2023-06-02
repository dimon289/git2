using Microsoft.Win32;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subKeyName = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
            string appName = "Epic Games";
            string appPath = "\"C:\\Games\\EpicGames\\Epic Games\\Launcher\\Portal\\Binaries\\Win32\\EpicGamesLauncher.exe\"";

            using (RegistryKey runKey = Registry.CurrentUser.OpenSubKey(subKeyName, true))
            {
                if (runKey == null)
                {
                    Console.WriteLine($"Registry key '{subKeyName}' not found.");
                    return;
                }

                try
                {
                    runKey.SetValue(appName, appPath);
                    Console.WriteLine("Program added to the 'Run' registry key.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to the registry: {ex.Message}");
                }
            }
        }
    }
}