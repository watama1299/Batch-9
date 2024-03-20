using GameControllerLib;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

class Program {
    static void Main() 
	{
		ILoggerFactory loggerFactory = LoggerFactory.Create(log =>
		{
			log.SetMinimumLevel(LogLevel.Information);
			log.AddNLog("nlog.config");
			// log.AddLog4Net("log4net.config");
		});
		ILogger<GameController> logger = loggerFactory.CreateLogger<GameController>();
		GameController game = new GameController(new Player("yanto"), new Board(2), logger);
	}
}