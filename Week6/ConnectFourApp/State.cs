namespace ConnectFourApp;

public class State
{
    Player [] players;
    int gameRoundsPlayed;
    bool gameOver;

    State()
    {
        players = new Players[]
        {
            new Player() { Name= "Player", Points = 0 },
            new Player() { Name= "Opponent", Points = 0 }
        };
        gameRoundsPlayed = 0;
        gameOver = false;
    }

    void ResetGame() 
    {
        gameOver = false;
        players[0].Points = 0;
        players[1].Points = 0;
    }

    void EndGame()
    {
        gameOver = true;
        gameRoundsPlayed++;
        // award winner..
    } 
}