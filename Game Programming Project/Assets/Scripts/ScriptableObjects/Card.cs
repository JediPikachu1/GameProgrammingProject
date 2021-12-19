﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    
    public new string name;
    

    public Sprite artwork;

    public int energyCost;
    public int damage;

    public int block;
    public int strength;

    
}
