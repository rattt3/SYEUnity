using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Equipped { get; set; }

    public Item(string name, int value)
    {
        Name = name;
        Value = value;
        Equipped = false;
    }

    public abstract string GetDescription();
}



