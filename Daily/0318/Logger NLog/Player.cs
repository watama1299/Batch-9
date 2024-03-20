using NLog;

namespace GameControllerLib;
public class Player : IPlayer
{
    public static Logger logger = LogManager.GetCurrentClassLogger();

	private string _name;
	public Player(string name) 
	{
		_name = name;
		logger.Info($"Player with name {_name} has been created");
	}
	public string GetName()
	{
		return _name;
	}

	public void SetName(string name)
	{
		if(name.Length > 2) {
			_name = name;
			logger.Info($"Player name has been changed to {_name}");
		}
	}
	public override string ToString()
	{
		return _name;
	}
	

}
