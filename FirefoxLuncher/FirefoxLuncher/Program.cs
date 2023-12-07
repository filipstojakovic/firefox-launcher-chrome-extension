﻿
using System.Diagnostics;

public class Program
{
	static void Main(string[] args)
	{
		// Path to the Firefox executable
		string firefoxPath = "C:\\Program Files\\Mozilla Firefox\\firefox.exe ";// -new-tab ";

		string urlToOpen = "";
		bool isPrivate = false;
		if (args.Length > 0)
		{
			urlToOpen = args[0];
			// Remove "ff://" prefix
			urlToOpen = urlToOpen.Replace("ff://", "");

			// Check for "--private" flag
			if (urlToOpen.Contains("--private"))
			{
				urlToOpen = urlToOpen.Replace("--private", "");
				isPrivate = true;
			}
		}
		// Start Firefox process
		StartFirefox(firefoxPath, urlToOpen, isPrivate);
	}

	static void StartFirefox(string path, string url, bool isPrivate)
	{
		try
		{
			ProcessStartInfo psi = new ProcessStartInfo(path);
			psi.ArgumentList.Add(isPrivate ? "-private-window" : "");
			psi.ArgumentList.Add(url);
			Process.Start(psi);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error starting Firefox: " + ex.Message);
		}
	}
}