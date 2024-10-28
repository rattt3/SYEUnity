using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsAndArmor : Item
{
    public int Damage { get; set; }

    public WeaponsAndArmor(string name, int value, int damage) : base(name, value)
    {
        Damage = damage;
    }

    public void Equip() 
    {
        Equipped = true;
    }

    public override string GetDescription() 
    {
        return $"{Name} (Value: {Value}, Damage: {Damage})";
    }
}