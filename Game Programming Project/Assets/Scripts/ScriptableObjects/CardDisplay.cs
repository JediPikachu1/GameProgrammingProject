using System.Collections;
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
    
    void Start()
    {
        nameText.text = card.name;
        if (card.damage > 0)
        {
            descriptionText.text = "You deal: " + card.damage.ToString() + " slashing damage";
        }
        else if (card.block > 0)
        {
            descriptionText.text = "You gain: " + card.block.ToString() + " block";
        }
        else if (card.strength > 0)
        {
            descriptionText.text = "You gain: " + card.strength.ToString() + " strength";
        }

        art.sprite = card.artwork;

        energyText.text = card.energyCost.ToString();
        //Debug.Log(energyText.text);
        //damageText.text = card.damage.ToString();
        //blockText.text = card.block.ToString();
    }

    // Update is called once per frame
    
}
