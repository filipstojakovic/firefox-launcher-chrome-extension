using Microsoft.Win32;

// Create or open the registry key under ClassesRoot for the "ff" protocol
RegistryKey key = Registry.ClassesRoot.CreateSubKey("ff");

// Set the default value and URL Protocol for the key
key.SetValue("", "URL: firefox Protocol");
key.SetValue("URL Protocol", "");

// Navigate to the necessary subkeys for the "shell", "open", and "command"
key = key.CreateSubKey("shell");
key = key.CreateSubKey("open");
key = key.CreateSubKey("command");

// Set the default value for the "command" key, specifying the executable path and %1 for the URL parameter
key.SetValue("", "C:\\Users\\filip\\source\\repos\\FirefoxLuncher\\FirefoxLuncher\\bin\\Debug\\net7.0\\FirefoxLuncher.exe" + " %1");
