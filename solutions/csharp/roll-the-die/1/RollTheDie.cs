public class Player
{
    public int RollDie()
    {
        var randomizer = new System.Random();
        return randomizer.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        var randomizer = new System.Random();
        return randomizer.NextDouble() * 100;
    }
}
