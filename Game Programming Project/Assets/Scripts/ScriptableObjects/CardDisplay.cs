﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public Card card;
    
    public Text nameText;
    public Text descriptionText;

    public Image art;

    public Text energyText;
    public Text damageText;
    public Text blockText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        art.sprite = card.artwork;

        energyText.text = card.energyCost.ToString();
        Debug.Log(energyText.text);
        //damageText.text = card.damage.ToString();
        //blockText.text = card.block.ToString();
    }

    // Update is called once per frame
    
}
