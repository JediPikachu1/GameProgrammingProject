using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCardsScript : MonoBehaviour
{
    
    public GameObject TestCard;
    public GameObject Hand;

    private Card forTest;
    public CardDisplay forTestDisplay;

    int maxHandsize = 7;

    void Start()
    {
        /*
        for(int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(TestCard, new Vector3(0,0,0), Quaternion.identity);
            playerCard.transform.SetParent(Hand.transform, false);
        }
        */
        forTest = Resources.Load("Cards/forTest") as Card;
        Card playerobject = Instantiate(forTest);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
