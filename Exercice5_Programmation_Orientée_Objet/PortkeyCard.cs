public class PortkeyCard : ChanceCard
{
    public PortkeyCard()
    {
        Type = ChanceCardType.Portkey;
    }

    public override void Execute(Character elfe, Character dragon)
    {
        Console.WriteLine("Elfe uses Portkey! Elfe moves forward 3 spaces.");
        elf.Move(3);
    }
}
