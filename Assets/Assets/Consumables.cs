public class Consumables : Item
{
    public int Duration { get; set; }

    public Consumables(string name, int value, int duration) : base(name, value)
    {
        Duration = duration;
    }

    public void Equip() 
    {
        Equipped = true;
    }

    public override string GetDescription() 
    {
        return $"{Name} (Value: {Value}, Duration: {Duration})";
    }
}