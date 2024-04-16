public class Elfe : Character
{
    public Elfe(string name) : base(name, 0) {}

    public override void Move(int steps)
    {
        Position = Math.Min(30, Position + steps);
    }
}
