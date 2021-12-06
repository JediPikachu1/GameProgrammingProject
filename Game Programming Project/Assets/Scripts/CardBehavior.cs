using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehavior : MonoBehaviour
{
    
    public bool isCast;
    public GameObject[] Hand;
    
    public PlayerScript Player;

    public int cardEnergy;
    void Start()
    {
        //Line for testing. comment out when no longer needed
        cardEnergy = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.FindGameObjectsWithTag("Card");
        if(Input.GetKey(KeyCode.Alpha1))
        {
            if(cardEnergy < Player.playerEnergy)
            {
                isCast = false;
            }
            else
            {
                isCast = true;
                Player.playerEnergy -= cardEnergy;
            }
        }
    }
}
