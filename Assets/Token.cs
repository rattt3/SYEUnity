using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
[CreateAssetMenu(fileName = "New Token", menuName = "Game/Token")]
public class Token : ScriptableObject
{
    [SerializeField] int HP;
    public int AC;
    public int Speed;
    public int Initiative;
    public bool Alive;
    public int ImId;
    public (int x, int y) Position;
    public int Strength;
    public int Dexterity;
    public int Constitution;
    public int Intelligence;
    public int Wisdom;
    public int Charisma;

    public Token(int hp, int ac, int speed, int initiative, bool alive, int imId, 
                 (int x, int y) position, int strength, int dexterity, 
                 int constitution, int intelligence, int wisdom, int charisma)
    {
        HP = hp;
        AC = ac;
        Speed = speed;
        Initiative = initiative;
        Alive = alive;
        ImId = imId;
        Position = position;
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }

    public void Attack() 
    {
        // Implementation for attack
    }

    public void Move(int x, int y) 
    {
        Position = (x, y);
    }

    public (int, int) GetPosition() 
    {
        return Position;
    }
    
}
