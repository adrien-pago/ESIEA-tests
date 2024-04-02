public class Dragon : Character
{
    public Dragon(string name) : base(name, 30) {}

    public override void Move(int steps)
    {
        Position = Math.Max(0, Position + steps);
    }
}
