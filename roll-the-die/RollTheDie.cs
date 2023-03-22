using System;

public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        return random.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        int integer = random.Next(1, 100);
        double decimalAddition = random.NextDouble();
        return integer + decimalAddition;  
    }
}
