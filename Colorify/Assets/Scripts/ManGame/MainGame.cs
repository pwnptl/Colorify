using static ColorifyColorEnum;
using static Player;
using static Constants;
using static MainGameHelper;
using UnityEngine;
public sealed class MainGame
{
    // Singleton Game
    private static MainGame instance = new MainGame();

    private MainGame() { init(); }

    public static MainGame Instance
    {
        get { return instance; }
    }
    public static void reset()
    {
        instance = new MainGame();
    }

    private Player[] players;
    private ColorifyColorEnum[,] gameGrid;
    public void init()
    {
        Constants.logMethod();
        // TODO : uncomment.
        //setGameGrid();
        //setPlayers();
    }

    private void setGameGrid()
    {

        gameGrid = new ColorifyColorEnum[Constants.gameGridRows, Constants.gameGridCols];

        for (int i = 0; i < Constants.gameGridRows; ++i)
        {
            for (int j = 0; i < Constants.gameGridCols; ++i)
            {
                gameGrid[i, j] = (ColorifyColorEnum)Random.Range(1, 7);
            }
        }
        //make sure both player's colors are different.
        while (gameGrid[0, 0] == gameGrid[Constants.gameGridRows - 1, Constants.gameGridCols - 1])
            gameGrid[0, 0] = (ColorifyColorEnum)Random.Range(1, 7);


    }
    private void setPlayers()
    {
        players = new Player[playerSize];
        players[0].Color = gameGrid[0, 0];
        players[1].Color = gameGrid[Constants.gameGridRows - 1, Constants.gameGridCols - 1];
    }
}