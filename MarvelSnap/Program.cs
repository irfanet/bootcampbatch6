using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using MarvelSnap;
using MarvelSnap.card;
using MarvelSnap.location;
using MarvelSnap.player;

class Program
{
	// TODO 
	// implement list card on location
	// implement score calculation
	// implement Card on Deck 
	// implement Serialization on Cards
	// Program.cs is too coupled need improvment
	// clears unusable function
	// implement delegate to notify user 
	// implement card skill & location effect
	static void Main()
	{
		Player p1 = new(1, "Irfan");
		Player p2 = new(2, "Nafri");

		Card card1 = new(1, "Hawkeys", "Hawkeys", CardType.Attack, 1, 1, "Location next turn, +3 Power");
		Card card2 = new(2, "Medusa", "Medusa", CardType.Attack, 2, 2, "If this is at middle location, +3 Power");
		Card card3 = new(3, "Sentinel", "Sentinel", CardType.Attack, 2, 3, "Add another Sentinel to your hand");
		Card card4 = new(4, "Iron Man", "Iron Man", CardType.Attack, 5, 0, "Your total Power is doubled at this location");
		Card card5 = new(5, "Hulk", "Hulk", CardType.Attack, 6, 12, "HULK SMASH!");
		Card card6 = new(6, "Mister Fantastic", "Mister Fantastic", CardType.Attack, 2, 3, "Adjacent locations have +2 Power.");
		Card card7 = new(7, "Juggernaut", "Juggernaut", CardType.Attack, 3, 3, "If your opponent played Card here this turn, move them randomly.");
		Card card8 = new(8, "Sandman", "Sandman", CardType.Attack, 5, 4, "Players can only play 1 card a turn");
		Card card9 = new(9, "Aero", "Aero", CardType.Attack, 5, 8, "Move the last enemy card played this turn to this location.");
		Card card10 = new(10, "Elektra", "Elektra", CardType.Attack, 1, 1, "Destroy a random enemy 1-Cost card at this location.");
		Card card11 = new(11, "Nebula", "Nebula", CardType.Attack, 1, 1, "Each turn your opponent doesn't play a card here, +2 Power. (except the turn you play this)");
		Card card12 = new(12, "Deathlok", "Deathlok", CardType.Attack, 3, 5, "Destroy your other Card at this location.");

		Card card111 = new(13, "Hawkeys", "Hawkeys", CardType.Attack, 1, 1, "Location next turn, +3 Power");
		Card card222 = new(14, "Medusa", "Medusa", CardType.Attack, 2, 2, "If this is at middle location, +3 Power");
		Card card333 = new(15, "Sentinel", "Sentinel", CardType.Attack, 2, 3, "Add another Sentinel to your hand");
		Card card444 = new(16, "Iron Man", "Iron Man", CardType.Attack, 5, 0, "Your total Power is doubled at this location");
		Card card555 = new(17, "Hulk", "Hulk", CardType.Attack, 6, 12, "HULK SMASH!");
		Card card666 = new(18, "Mister Fantastic", "Mister Fantastic", CardType.Attack, 2, 3, "Adjacent locations have +2 Power.");
		Card card777 = new(19, "Juggernaut", "Juggernaut", CardType.Attack, 3, 3, "If your opponent played Card here this turn, move them randomly.");
		Card card888 = new(20, "Sandman", "Sandman", CardType.Attack, 5, 4, "Players can only play 1 card a turn");
		Card card999 = new(21, "Aero", "Aero", CardType.Attack, 5, 8, "Move the last enemy card played this turn to this location.");
		Card card100 = new(22, "Elektra", "Elektra", CardType.Attack, 1, 1, "Destroy a random enemy 1-Cost card at this location.");
		Card card110 = new(23, "Nebula", "Nebula", CardType.Attack, 1, 1, "Each turn your opponent doesn't play a card here, +2 Power. (except the turn you play this)");
		Card card120 = new(24, "Deathlok", "Deathlok", CardType.Attack, 3, 5, "Destroy your other cards at this location.");

		List<Card> listCards = new()
		{
			card1,
			card2,
			card3,
			card4,
			card5,
			card6,
			card7,
			card8,
			card9,
			card10,
			card11,
			card12
		};

		List<Card> listCards2 = new()
		{
			card111,
			card222,
			card333,
			card444,
			card555,
			card666,
			card777,
			card888,
			card999,
			card100,
			card110,
			card120
		};

		PlayerData p1Data = new(listCards, PlayerStatus.OnGoing);
		PlayerData p2Data = new(listCards2, PlayerStatus.OnGoing);

		GameController gameController = new GameController();
		gameController.AddCardsToDeck(p1, p1Data);
		gameController.AddCardsToDeck(p2, p2Data);

		Location location1 = new(1, "Altar of Death", "After you play a card here, destroy it to get +2 Energy next turn.", 1);
		Location location2 = new(2, "Asgard", "After turn 4, whoever is winning here draws 2.", 2);
		Location location3 = new(3, "Atlantis", "If you only have one card here, it has +5 Power.", 3);

		List<Location> listLocation = new(){
			location1,
			location2,
			location3
		};

		int maxTurn = 6;
		int turnCounter = 0;

		Dictionary<Player, PlayerData> playerData = gameController.GetPlayerData();
		// List<Cards> player1 = gameController.GetCardsOnHand(Player);
		// List<Cards> player2 = gameController.GetCardsOnHand(Player);
		while (turnCounter <= maxTurn)
		{
			turnCounter++;
			bool isFirstTurn = turnCounter == 1 ? true : false;
			isFirstTurn.Dump();
			foreach (var e in playerData)
			{
				e.Value.SetEnergy(turnCounter);
				$"================= Player {e.Key.GetId()} : {e.Key.GetName()} ===============".Dump();
				$"Turn = {turnCounter} / {maxTurn}".Dump();
				$"Energy: {e.Value.GetEnergy()}".Dump();
				// Console.WriteLine(e.Value.GetScore());

				int CardLimit = 0;
				foreach (var y in e.Value.SetCardsOnHand(isFirstTurn))
				{
					// if (!y.IsUsed())
					// {
					$"-------------- Card Id : {y.GetId()} ---------------".Dump();
					$"Cost: {y.GetEnergyCost()} \t\t\t".DumpThis();
					$"Power: {y.GetPower()}".Dump();
					$"\t\t {y.GetName()}".Dump();
					$"[ {y.GetDescription()} ]".Dump();
					Console.WriteLine("------------------------------------------");
					// }

				}

				"".Dump();
				"=============== Location ==============".Dump();
				foreach (var locationElement in listLocation)
				{
					$"{locationElement.GetId()}. {locationElement.GetName()}".DumpThis();
					locationElement.GetEffect().Dump();
				}
				bool isEndTurn = false;
				while (!isEndTurn)
				{
					"Pick your card: ".Dump();
					"0: EndTurn 00: Retreat".Dump();
					int inputCard = int.Parse(Console.ReadLine());
					if (inputCard == 0)
					{
						isEndTurn = true;
					}
					else if (e.Value.GetCard(inputCard).GetEnergyCost() <= e.Value.GetEnergy())
					{
						"Success select card".Dump();
						e.Value.GetCard(inputCard).MarkOnLocation();
						"Select location: ".Dump();
						int? inputLocation = int.Parse(Console.ReadLine());
						gameController.GetLocation(inputLocation);
					}
					else
					{
						"ERROR! Lack of Energy".Dump();
					}
				}
				// Console.Clear();
				"".Dump();

			}
		}
		// Console.WriteLine(game.CheckWinner());
	}


}

static class MyExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}

	public static void DumpThis(this object obj)
	{
		Console.Write(obj);
	}
	public static void CardPrinter(Card cards)
	{
		Console.WriteLine($"Id : {cards.GetId()}");
		Console.WriteLine($"Name : {cards.GetName()}");
		Console.WriteLine($"Cost : {cards.GetEnergyCost()}");
		Console.WriteLine($"Power : {cards.GetPower()}");
		Console.WriteLine($"Description : {cards.GetDescription()}");

	}
}