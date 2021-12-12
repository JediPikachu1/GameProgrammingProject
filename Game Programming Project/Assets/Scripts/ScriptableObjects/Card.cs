using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    // Start is called before the first frame update
    public new string name;
    public string description;

    public Sprite artwork;

    public int energyCost;
    public int damage;

    public int block;

    // Update is called once per frame
}
