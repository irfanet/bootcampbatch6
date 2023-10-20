<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Card
class Card {
	private CardStatus status; 
}
public enum CardStatus {
	OnDeck,
	OnPlayer,
	Removed
}
public enum GameStatus {
	Win,
	Lose,
	Draw
}
public enum Days {
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday,
	Sunday
}