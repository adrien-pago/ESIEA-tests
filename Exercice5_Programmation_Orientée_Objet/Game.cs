using System;
using System.Collections.Generic;

public class Game
{
    private Elfe elfe;
    private Dragon dragon;
    private Dice dice;
    private List<ChanceCard> chanceCards;
    private int maxAttempts;
    private int currentAttempts;

    public Game(int attempts)
    {
        elfe = new Elfe("Heroic Elfe");
        dragon = new Dragon("Fierce Dragon");
        dice = new Dice();
        maxAttempts = attempts;
        currentAttempts = 0;
        InitializeChanceCards();
    }

    private void InitializeChanceCards()
    {
        chanceCards = new List<ChanceCard>
        {
            new SpellCard(),
            new EscapeCard(),
            new PortkeyCard()
        };
    }

    public void Play()
    {
        while (currentAttempts < maxAttempts && elfe.Position < 31)
        {
            // Elfe's turn
            int roll = dice.Roll();
            Console.WriteLine($"Elfe rolls: {roll}");
            elfe.Move(roll);

            // Check encounter
            if (elfe.Position == dragon.Position)
            {
                Console.WriteLine("Elfe encounters Dragon!");
                var card = DrawChanceCard();
                card.Execute(elf, dragon);
            }

            // Dragon's turn
            roll = dice.Roll();
            Console.WriteLine($"Dragon rolls: {roll}");
            dragon.Move(roll);

            // Check encounter
            if (elfe.Position == dragon.Position)
            {
                Console.WriteLine("Dragon encounters Elf!");
                if (dice.Roll() <= 3)
                {
                    Console.WriteLine("Elf suffers an attack!");
                    elfe.Move(-2); // Elfe moves back 2 spaces
                }
                else
                {
                    var card = DrawChanceCard();
                    card.Execute(elfe, dragon);
                }
            }

            Console.WriteLine($"Elf's position: {elfe.Position}, Dragon's position: {dragon.Position}");
            if (elfe.Position >= 31)
            {
                Console.WriteLine("Elf wins the treasure!");
                return;
            }

            // Reset if needed
            if (elfe.Position == 0)
            {
                currentAttempts++;
                Console.WriteLine($"Elf is back at the start. Attempt {currentAttempts} of {maxAttempts}.");
            }
        }

        Console.WriteLine("Game over. Dragon wins.");
    }

    private ChanceCard DrawChanceCard()
    {
        Random rnd = new Random();
        int index = rnd.Next(chanceCards.Count);
        return chanceCards[index];
    }
}
