using log4net;

namespace GameControllerLib;


public class Board : IBoard
{
	public static ILog logger = LogManager.GetLogger(typeof(Board));

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
