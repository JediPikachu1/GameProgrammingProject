using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFunction : MonoBehaviour
{
    
    public GameObject[] deckCards;
    public GameObject Hand;
    
    [SerializeField] private GameObject[] HandAccess;
    public GameObject[] Deck;
    public GameObject[] Discard;

    public GameObject HandCounter;

    public int discardCount;

    int maxHandsize = 5;

    public bool firstIsCast, secondIsCast, thirdIsCast, fourthIsCast, fifthIsCast;

    GameObject playerCard;

    [SerializeField] private int cardEnergy;
    [SerializeField] private int cardDamage;
    [SerializeField] private int cardBlock;

    int discardCardNumber;

    public ScriptEndTurn end;

    public PlayerScript player;
    public EnemyHealthAi enemy;

    void Awake()
    {
        DeckInstantiate();
    }

    void Start()
    {
        
        InitialDrawCardtoHandsize();
        isCast();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!firstIsCast)
            {
                cardEnergy = HandAccess[0].GetComponent<CardDisplay>().card.energyCost;
                cardDamage = HandAccess[0].GetComponent<CardDisplay>().card.damage;
                cardBlock = HandAccess[0].GetComponent<CardDisplay>().card.block;

                if (cardEnergy > player.playerEnergy)
                {
                    firstIsCast = false;
                }
                else
                {
                    firstIsCast = true;
                    player.playerEnergy -= cardEnergy;

                    if (cardDamage > 0)
                    {
                        enemy.EnemyTakeDamage(cardDamage + player.strength);
                    }
                    else if (cardBlock > 0)
                    {
                        player.BlockIntUpdate(cardBlock);
                    }
                    System.Array.Resize(ref Discard, discardCount++);
                    Discard[discardCardNumber++] = HandAccess[0];
                    Transform remove = Hand.transform.GetChild(0);
                    remove.gameObject.SetActive(false);
                    remove = HandCounter.transform.GetChild(0);
                    remove.gameObject.SetActive(false);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!secondIsCast)
            {
                cardEnergy = HandAccess[1].GetComponent<CardDisplay>().card.energyCost;
                cardDamage = HandAccess[1].GetComponent<CardDisplay>().card.damage;
                cardBlock = HandAccess[1].GetComponent<CardDisplay>().card.block;


                if (cardEnergy > player.playerEnergy)
                {
                    secondIsCast = false;
                }
                else
                {
                    secondIsCast = true;
                    player.playerEnergy -= cardEnergy;

                    if (cardDamage > 0)
                    {
                        enemy.EnemyTakeDamage(cardDamage + player.strength);
                    }
                    else if (cardBlock > 0)
                    {
                        player.BlockIntUpdate(cardBlock);
                    }
                    System.Array.Resize(ref Discard, discardCount++);
                    Discard[discardCardNumber++] = HandAccess[1];
                    Transform remove = Hand.transform.GetChild(1);
                    remove.gameObject.SetActive(false);
                    remove = HandCounter.transform.GetChild(1);
                    remove.gameObject.SetActive(false);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!thirdIsCast)
            {
                cardEnergy = HandAccess[2].GetComponent<CardDisplay>().card.energyCost;
                cardDamage = HandAccess[2].GetComponent<CardDisplay>().card.damage;
                cardBlock = HandAccess[2].GetComponent<CardDisplay>().card.block;

                if (cardEnergy > player.playerEnergy)
                {
                    thirdIsCast = false;
                }
                else
                {
                    thirdIsCast = true;
                    player.playerEnergy -= cardEnergy;

                    if (cardDamage > 0)
                    {
                        enemy.EnemyTakeDamage(cardDamage + player.strength);
                    }
                    else if (cardBlock > 0)
                    {
                        player.BlockIntUpdate(cardBlock);
                    }
                    System.Array.Resize(ref Discard, discardCount++);
                    Discard[discardCardNumber++] = HandAccess[2];
                    Transform remove = Hand.transform.GetChild(2);
                    remove.gameObject.SetActive(false);
                    remove = HandCounter.transform.GetChild(2);
                    remove.gameObject.SetActive(false);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (!fourthIsCast)
            {
                cardEnergy = HandAccess[3].GetComponent<CardDisplay>().card.energyCost;
                cardDamage = HandAccess[3].GetComponent<CardDisplay>().card.damage;
                cardBlock = HandAccess[3].GetComponent<CardDisplay>().card.block;

                if (cardEnergy > player.playerEnergy)
                {
                    fourthIsCast = false;
                }
                else
                {
                    fourthIsCast = true;
                    player.playerEnergy -= cardEnergy;

                    if (cardDamage > 0)
                    {
                        enemy.EnemyTakeDamage(cardDamage + player.strength);
                    }
                    else if (cardBlock > 0)
                    {
                        player.BlockIntUpdate(cardBlock);
                    }
                    System.Array.Resize(ref Discard, discardCount++);
                    Discard[discardCardNumber++] = HandAccess[3];
                    Transform remove = Hand.transform.GetChild(3);
                    remove.gameObject.SetActive(false);
                    remove = Hand.transform.GetChild(3);
                    remove.gameObject.SetActive(false);
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (!fifthIsCast)
            {
                cardEnergy = HandAccess[4].GetComponent<CardDisplay>().card.energyCost;
                cardDamage = HandAccess[4].GetComponent<CardDisplay>().card.damage;
                cardBlock = HandAccess[4].GetComponent<CardDisplay>().card.block;

                if (cardEnergy > player.playerEnergy)
                {
                    fifthIsCast = false;
                }
                else
                {
                    fifthIsCast = true;
                    player.playerEnergy -= cardEnergy;

                    if (cardDamage > 0)
                    {
                        enemy.EnemyTakeDamage(cardDamage + player.strength);
                    }
                    else if (cardBlock > 0)
                    {
                        player.BlockIntUpdate(cardBlock);
                    }
                    System.Array.Resize(ref Discard, discardCount++);
                    Discard[discardCardNumber++] = HandAccess[4];
                    Transform remove = Hand.transform.GetChild(4);
                    remove.gameObject.SetActive(false);
                    remove = HandCounter.transform.GetChild(4);
                    remove.gameObject.SetActive(false);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            end.EndTurn();
        }
    }

    public void isCast()
    {
        firstIsCast = false;
        secondIsCast = false;
        thirdIsCast = false;
        fourthIsCast = false;
        fifthIsCast = false;
    }

    void DeckInstantiate()
    {
        Deck = new GameObject[10];
        
        /*
        for (int i = 0; i < 4; i++)
            Deck[i] = deckCards[0];

        Deck[4] = deckCards[1];

        for (int i = 5; i < 8; i++)
            Deck[i] = deckCards[2];
        */
        

        for (int i = 0; i < Deck.Length; ++i)
        {
            int cardIndex = Random.Range(0, deckCards.Length);
            Deck[i] = deckCards[cardIndex];
        }
        
        
        discardCount = 1;
        Discard = new GameObject[discardCount];
        discardCardNumber = 0;
    }
    public void InitialDrawCardtoHandsize()
    {
        for(int i = 0; i < maxHandsize; i++)
        {
            playerCard = Instantiate(Deck[Deck.Length -1], new Vector3(0,0,0), Quaternion.identity);
            HandAccess[i] = Deck[Deck.Length - 1];
            playerCard.transform.SetParent(Hand.transform, false);
            System.Array.Resize(ref Deck, Deck.Length -1);
        }
    }

    public void EndTurnDiscard()
    {
        for (int i = 0; i < maxHandsize; i++)
        {
            if (Hand.transform.GetChild(i).gameObject.activeSelf)
            {
                Hand.transform.GetChild(i).gameObject.SetActive(false);
                System.Array.Resize(ref Discard, ++discardCount);
                Discard[discardCount - 1] = HandAccess[i];
            }
        }

        for (int i = 0; i < maxHandsize; i++)
        {
            Destroy(Hand.transform.GetChild(i));
        }
    }

    public void DrawCardstoHandsize()
    {
        if (Deck.Length == 0)
        {
            Deck = new GameObject[10];
            for (int i = 0; i < Discard.Length; ++i)
            {
                Deck[i] = Discard[i];
            }
            InitialDrawCardtoHandsize();
        }
        else
        {
            InitialDrawCardtoHandsize();
        }

    }
}
