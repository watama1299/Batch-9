using GameControllerLib;
using log4net;
using log4net.Config;

class Program {
    public static ILog logger = LogManager.GetLogger(typeof(Program));

    static void Main(string[] args)
    {
        XmlConfigurator.Configure(new FileInfo("./log4net.config"));
        logger.Info("Program has started");
        var player = new Player("abc");
        var board = new Board(5);
        var gc = new GameController(player, board);





        logger.Info("Program is ending");
    }
}