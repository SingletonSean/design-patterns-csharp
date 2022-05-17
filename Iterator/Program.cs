using Iterator.Models;

void Iterate(IPlayerCollection playerCollection)
{
    foreach (Player player in playerCollection)
    {
        Console.WriteLine(player);
    }
}

Team phoenixSuns = new Team()
{
    Players = new Player[]
    {
        new Player("Chris", "Paul", 14.7),
        new Player("Devin", "Booker", 26.8),
        new Player("Deandre", "Ayton", 17.2)
    }
};

Team goldenStateWarriors = new Team()
{
    Players = new Player[]
    {
        new Player("Stephen", "Curry", 25.5),
        new Player("Klay", "Thompson", 20.4),
        new Player("Draymond", "Green", 7.5)
    }
};

League nba = new League()
{
    Teams = new Team[]
    {
        phoenixSuns,
        goldenStateWarriors
    }
};

Iterate(nba);

Console.ReadKey();