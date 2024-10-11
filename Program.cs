// See https://aka.ms/new-console-template for more information

using game1401_la_5;

Console.WriteLine("Hello, World!");
LearningActivity5_1();
return;

void LearningActivity5_1()
{
    string initialsInput;

    HighscoreBoard hs = new HighscoreBoard();

    Random randomScore = new Random();
    while (true)
    {
        GameSelection choice = ChooseOption();
        switch (choice)
        {
            case GameSelection.Play:
                int newHighScore = randomScore.Next(1000, 1000000);
                Console.WriteLine("Please input your initials");
                initialsInput = Console.ReadLine();
                if (initialsInput.Length < 3)
                {
                    hs.AddScore(newHighScore, initialsInput);
                }
                else
                {
                    Console.WriteLine("incorect input, make sure you put in 2 letters only");
                    break;
                }

                Console.WriteLine($"You finished with a score of {newHighScore}");

                break;
            case GameSelection.SeeHighScore:
                hs.PrintScores();
                break;

        }

    }
}

GameSelection ChooseOption()
{
    bool validSelection = false;
    int selection = 0;
    while (!validSelection)
    {
        Console.WriteLine(
            "Would you like to:\n\t 1: Play again\n\t 2: See the list of high scores\n\t 3: Exit the game?");

        if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= 3)
            validSelection = true;

    }

    Console.Clear();
    return (GameSelection)selection;

}
//Be kind, rewind.
void LearningActivity5_2()
{
    Database database = new Database();
    database.UserInput();
}

enum GameSelection
{
    Play = 1, SeeHighScore = 2, Exit = 3
}