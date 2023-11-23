namespace Interfaces
{
	public class FileLogger : ILogger
	{
		private readonly string _path;

		public FileLogger(string path)
		{
			_path = path;
		}
		public void LogError(string message)
		{
			Log(message, LogLevel.Error);
		}

		public void LogInfo(string message)
		{
			Log(message, LogLevel.Info);

		}

		private void Log(string message, LogLevel logLevel)
		{
			using (var streamWriter = new StreamWriter(_path, true))
			{
				streamWriter.WriteLine(logLevel + ": " + message);
			}
		}
	}
}