using UnityEngine;

public class PlayerCardGA : GameAction
{
    public Card Card {  get; set; }
    public PlayerCardGA(Card card)
    {
        Card = card;
    }
}
