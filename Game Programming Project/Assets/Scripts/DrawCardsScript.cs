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

    int maxHandsize = 5;

    public bool isCast;

    public int cardEnergy;

    public PlayerScript player;

    void Awake()
    {
        DeckInstantiate();
    }

    void Start()
    {
        
        DrawCardtoHandsize();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cardEnergy = HandAccess[0].GetComponent<CardDisplay>().card.energyCost;

            if(cardEnergy > player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                player.playerEnergy -= cardEnergy;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            cardEnergy = HandAccess[1].GetComponent<CardDisplay>().card.energyCost;

            if(cardEnergy > player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                player.playerEnergy -= cardEnergy;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            cardEnergy = HandAccess[2].GetComponent<CardDisplay>().card.energyCost;

            if(cardEnergy > player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                player.playerEnergy -= cardEnergy;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            cardEnergy = HandAccess[3].GetComponent<CardDisplay>().card.energyCost;

            if(cardEnergy > player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                player.playerEnergy -= cardEnergy;
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            cardEnergy = HandAccess[4].GetComponent<CardDisplay>().card.energyCost;

            if(cardEnergy > player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                player.playerEnergy -= cardEnergy;
            }
        }
    }

    void DeckInstantiate()
    {
        Deck = new GameObject[8];
        for (int i = 0; i < 4; i++)
            Deck[i] = deckCards[0];

        Deck[4] = deckCards[1];

        for (int i = 5; i < 8; i++)
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
