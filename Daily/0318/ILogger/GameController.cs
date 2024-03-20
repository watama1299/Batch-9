using Microsoft.Extensions.Logging;

namespace GameControllerLib;

public class GameController
{

	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	private ILogger<GameController>? _log;
	public event Action<ICard>? OnCardUpdate;

	public GameController(IPlayer player, IBoard board, ILogger<GameController>? logger = null)
	{
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		_log = logger;
		_log?.LogInformation($"GameController with player [{player}] and board [{board}] has been created");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			_log?.LogWarning("Player not found!");
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
			_log?.LogWarning("Player not found!");
			return Enumerable.Empty<ICard>();
		}

		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
			_log?.LogWarning("Player not found!");
			return false;
		}

		if (!_players[player].Contains(card))
		{
			_log?.LogWarning("Card not found!");
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
	}
}
