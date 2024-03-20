using Moq;
namespace SimpleGameProject.Test;

public class GameController
{
	private IList<IPlayer> _players;

	public GameController(IList<IPlayer> players)
	{
		_players = players;
	}

	public IList<IPlayer> GetListPlayers()
	{
		return _players;
	}
}
public interface IPlayer
{
	int Level{ get; set; }
	int ID { get; set; }
	string GetName();
	bool SetName(string name);
}

// NEED TO GIVE THIS ATTRIBUTE TO MARK AS TEST
[TestFixture]
public class GameControllerTest 
{
	[Test]
	public void GetListPlayers_ReturnRegisteredPlayers_PlayersAddedOnConstructor() 
	{
		//Arrange
		Mock<IPlayer> player1 = new Mock<IPlayer>();
		player1.SetupProperty(u => u.Level, 1);
		// player1.SetupProperty(u => u.ID, 123);
		player1.Setup(p => p.GetName()).Returns("Joko");
		//player1.Setup(p => p.SetName(It.IsAny<string>())).Returns(true);
		
		Mock<IPlayer> player2 = new Mock<IPlayer>();
		// player2.SetupProperty(u => u.Level, 2);
		// player2.SetupProperty(u => u.ID, 156);
		player2.Setup(p => p.GetName()).Returns("Widodo");
		//player2.Setup(p => p.SetName(It.IsAny<string>())).Returns(true);
		
		List<IPlayer> players = new List<IPlayer>();
		players.Add(player1.Object);
		players.Add(player2.Object);
		
		GameController game = new GameController(players);
		
		//Act
		IList<IPlayer> result = game.GetListPlayers();
		
		//Assert
		Assert.AreEqual(2, result.Count);
		Assert.AreEqual("Joko", result[0].GetName());
		Assert.AreEqual("Widodo", result[1].GetName());
	}
}