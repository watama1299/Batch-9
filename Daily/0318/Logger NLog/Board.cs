using NLog;
namespace GameControllerLib;


public class Board : IBoard
{
    public static Logger logger = LogManager.GetCurrentClassLogger();

	private int _size;
	public string name;
	public Board(int size) 
	{
		_size = size;
		logger.Info($"Board with size {_size} has been created");
	}
	public int GetSize()
	{
		return _size;
	}

}
