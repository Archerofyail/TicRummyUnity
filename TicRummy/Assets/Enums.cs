using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Suit
{
    Heart,
    Diamond,
    Spade,
    Club,
    Joker

}

public enum Number
{
    Joker,
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

public static class CardHelper
{
    public static List<Card> GetSingleDeck()
    {
        var newDeck = new List<Card>(52);
        var suit = Suit.Heart;
        var num = Number.Ace;
        for (int i = 0; i < 3; i++)
        {
            suit = (Suit)i;
            for (int j = 1; j < 13; j++)
            {
                num = (Number)j;
                newDeck.Add(new Card(suit, num));
            }
        }
        newDeck.Add(new Card(Suit.Joker, Number.Joker));
        newDeck.Add(new Card(Suit.Joker, Number.Joker));
        return newDeck;
    }
    public static List<Card> GetDeck(int numDecks)
    {
        var newDeck = new List<Card>(52 * numDecks);
        for (int i = 0; i < numDecks; i++)
        {
            newDeck.AddRange(GetSingleDeck());
        }

        return newDeck;
    }
    public static List<Card> ShuffleDeck(List<Card> deck)
    {
        var shuffledDeck = new List<Card>(deck.Count);

        for (int i = 0; i < deck.Count; i++)
        {
            shuffledDeck.Add(deck[Random.Range(0, deck.Count - 1)]);
        }

        return shuffledDeck;
    }
}

public struct Card
{
    public Suit Suit { get; }
    public Number Number { get; }

    public Card(Suit suit, Number number)
    {
        Suit = suit;
        Number = number;
    }
}
