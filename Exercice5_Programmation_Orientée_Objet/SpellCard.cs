public class SpellCard : ChanceCard
{
    public SpellCard()
    {
        Type = ChanceCardType.Spell;
    }

    public override void Execute(Character elfe, Character dragon)
    {
        Console.WriteLine("Elfe uses Spell! Dragon moves back 3 spaces.");
        dragon.Move(-3);
    }
}
