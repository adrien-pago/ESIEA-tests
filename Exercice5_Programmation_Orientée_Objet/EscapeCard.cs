public class EscapeCard : ChanceCard
{
    public EscapeCard()
    {
        Type = ChanceCardType.Escape;
    }

    public override void Execute(Character elfe, Character dragon)
    {
        Console.WriteLine("Elfe uses Escape! Elfe moves back 1 space.");
        elfe.Move(-1);
    }
}
