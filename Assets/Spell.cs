using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string Name { get; set; }
    public int SpellLevel { get; set; }
    public int Cost { get; set; }
    public int Range { get; set; }
    public int Damage { get; set; }
    public int Duration { get; set; }

    public Spell(string name, int spellLevel, int cost, int range, int damage, int duration)
    {
        Name = name;
        SpellLevel = spellLevel;
        Cost = cost;
        Range = range;
        Damage = damage;
        Duration = duration;
    }

    public void Cast() 
    {
        // Implementation for casting the spell
    }

    public string GetDescription() 
    {
        return $"{Name} (Level: {SpellLevel}, Cost: {Cost}, Range: {Range}, Damage: {Damage}, Duration: {Duration})";
    }

    public bool IsAvailable(int spellLevel) 
    {
        return SpellLevel <= spellLevel; // Check if spell is available
    }
}
