using System;

public class Player
{
    public string Name { get; set; }

    public int Score { get; set; }
}

public class GameOfNames
{
    private static void Main()
    {
        int countOfPlayers = int.Parse(Console.ReadLine());

        Player[] players = new Player[countOfPlayers];

        for (int i = 0; i < countOfPlayers; i++)
        {
            players[i] = new Player();

            players[i].Name = Console.ReadLine();
            players[i].Score = int.Parse(Console.ReadLine());

            for (int j = 0; j < players[i].Name.Length; j++)
            {
                int asciiCode = players[i].Name[j];

                if (asciiCode % 2 == 0)
                {
                    players[i].Score += asciiCode;
                }
                else
                {
                    players[i].Score -= asciiCode;
                }
            }
        }

        Player playerWithMaxScore = players[0];

        for (int i = 1; i < countOfPlayers; i++)
        {
            if (players[i].Score > playerWithMaxScore.Score)
            {
                playerWithMaxScore = players[i];
            }
        }

        Console.WriteLine("The winner is {0} - {1} points", playerWithMaxScore.Name, playerWithMaxScore.Score);
    }
}
