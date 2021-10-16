using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{

    public List<Card> Pile { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void AddCard(Card card)
    {

        Pile.Add(card);
    }

    void AddCards(IEnumerable<Card> cards)
    {
        Pile.AddRange(cards);
    }

    Card TakeCard()
    {
        var card = Pile[Pile.Count - 1];
        Pile.RemoveAt(Pile.Count - 1);
        return card;
    }
}
