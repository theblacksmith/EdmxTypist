namespace Util
{
	using System.IO;

	public class Logger
	{
		private FileStream fs;
		private StreamWriter writer;

		public Logger()
		{
			//get file name (dll name + ".log")
			const string logFile = @"output\log.txt";

			if (!File.Exists(logFile))
				fs = new FileStream(logFile, FileMode.Create, FileAccess.Write, FileShare.None);
			else
				fs = new FileStream(logFile, FileMode.Truncate, FileAccess.Write, FileShare.None);

		    writer = new StreamWriter(fs) {AutoFlush = true};
		}

		~Logger()
		{
            if(writer != null)
				writer.Dispose();
		}

		public void Log(string t)
		{
			writer.WriteLine(t);
		}
	}
}
