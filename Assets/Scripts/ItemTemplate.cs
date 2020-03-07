﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemTemplate : ScriptableObject
{
    public string itemName;
    public string description;

    public Sprite itemSprite;

    public int rarity;
    public int energy;
    public int attack;    
}
