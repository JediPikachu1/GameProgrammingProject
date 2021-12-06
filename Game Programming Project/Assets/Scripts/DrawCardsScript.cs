using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCardsScript : MonoBehaviour
{
    
    public GameObject TestCard;
    public GameObject Hand;

    int maxHandsize = 7;

    void Start()
    {
        
        for(int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(TestCard, new Vector3(0,0,0), Quaternion.identity);
            playerCard.transform.SetParent(Hand.transform, false);
        }
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
