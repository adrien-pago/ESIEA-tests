public abstract class Character
{
    public string Name { get; set; }
    public int Position { get; set; }

    protected Character(string name, int position)
    {
        Name = name;
        Position = position;
    }

    public abstract void Move(int steps);
}
