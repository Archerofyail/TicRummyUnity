using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    GameManager gm;
    [SerializeField]
    List<Card> deck;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        deck = CardHelper.ShuffleDeck(CardHelper.GetDeck(gm.NumDecks));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Card Draw()
    {

        var card = deck[deck.Count - 1];
        deck.RemoveAt(deck.Count - 1);

        return card;
    }
    public List<Card> DrawCards(int numCards)
    {
        var cards = new List<Card>(numCards);
        for (int i = 0; i < numCards; i++)
        {
            cards.Add(deck[deck.Count - 1]);
            deck.RemoveAt(deck.Count - 1);
        }
        return cards;
    }
}
