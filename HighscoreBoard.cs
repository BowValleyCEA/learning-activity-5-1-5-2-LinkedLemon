using System;

public class HighscoreBoard
{
    private List<(int score, string initials)> highscores;
    public HighscoreBoard()
    {

        highscores = new List<(int, string)>();

    }

    //NEEDS TO:
    //be able to add new scores
    public void AddScore(int score, string initials)
    {
        highscores.Add((score, initials));
    }

    //display the top 10 scores, descending

    public void PrintScores()
    {
        highscores.Sort();
        highscores.Reverse();
        if (highscores.Count == 0)
        {
            Console.WriteLine("No highscores found");
        }
        else if (highscores.Count < 10)
        {
            foreach ((int, string) i in highscores)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(highscores[i]);
            }
        }
    }
}