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
        return random.Next(0.0, 100.0);
    }
}
