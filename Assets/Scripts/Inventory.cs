using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
    private List<ItemTemplate> itemList;

    public Inventory() {
        itemList = new List<ItemTemplate>();

        Debug.Log("Inventory");
    }
}
