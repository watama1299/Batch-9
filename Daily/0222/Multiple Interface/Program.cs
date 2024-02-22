class ChessGame {
    IPlayer[] players;
    public void AddPlayer(IPlayer player) {}
}

class ChessOnlineGame {
    IOnlinePlayer[] onlinePlayers;
    public void AddPlayer(IOnlinePlayer onlinePlayer) {}
    public string CheckElo(IOnlinePlayer onlinePlayer) {
        return onlinePlayer.ELO;
    }
}


public interface IPlayer {
    public string Name {get; set;}
    public int ID {get; set;}
}

public interface IOnlinePlayer : IPlayer {
    public string UserName {get; set;}
    public string Email {get; set;}
    public string ELO {get; set;}
}



class Player : IPlayer {
	public int ID {get;set;}
	public string Name {get;set;}
}
class OnlinePlayer : IOnlinePlayer {
	public int ID {get;set;}
	public string Name {get;set;}
	public string UserName {get;set;}
	public string Email {get;set;}
    public string ELO {get; set;}
}