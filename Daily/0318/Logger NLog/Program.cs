using GameControllerLib;
using NLog;

class Program {
    public static Logger logger = LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
        logger.Info("Program has started");
        var player = new Player("abc");
        var board = new Board(5);
        var gc = new GameController(player, board);





        logger.Info("Program is ending");
    }
}