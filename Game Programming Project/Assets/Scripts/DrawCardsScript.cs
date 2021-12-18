using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCardsScript : MonoBehaviour
{
    
    public GameObject[] deckCards;
    public GameObject Hand;
    
    [SerializeField] private GameObject[] HandAccess;
    public GameObject[] Deck;

    private Card forTest;
    public CardDisplay forTestDisplay;

    public GameObject test;

    int maxHandsize = 5;

    void Start()
    {
        DrawCardtoHandsize();
        
        
        
        //forTest = Resources.Load("Cards/forTest") as Card;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeckInstance()
    {
        Deck = new GameObject[8];
        for (int i = 0; i < 3; i++)
            Deck[i] = deckCards[0];

        Deck[4] = deckCards[1];

        for (int i = 5; i < 7; i++)
            Deck[i] = deckCards[2];
        
    }
    void DrawCardtoHandsize()
    {
        for(int i = 0; i < maxHandsize; i++)
        {
            int cardIndex = Random.Range(0, Deck.Length - 1);
            GameObject playerCard = Instantiate(Deck[cardIndex], new Vector3(0,0,0), Quaternion.identity);
            HandAccess[i] = Deck[cardIndex];
            playerCard.transform.SetParent(Hand.transform, false);
        }
    }
}
