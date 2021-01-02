using static ColorifyColorEnum;
using static Player;
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


    /// now we begin
    private int playerSize = 2;
    private Player[] players;
    private ColorifyColorEnum[,] gameGrid;
    private int gameGridRows = 16;
    private int gameGridCols = 24;
    public void init()
    {
        setGameGrid();
        setPlayers();
    }

    private void setGameGrid()
    {

        gameGrid = new ColorifyColorEnum[gameGridRows, gameGridCols];

        for (int i = 0; i < gameGridRows; ++i)
        {
            for (int j = 0; i < gameGridCols; ++i)
            {
                gameGrid[i, j] = (ColorifyColorEnum)Random.Range(1, 7);
            }
        }
        //make sure both player's colors are different.
        while (gameGrid[0, 0] == gameGrid[gameGridRows - 1, gameGridCols - 1])
            gameGrid[0, 0] = (ColorifyColorEnum)Random.Range(1, 7);


    }
    private void setPlayers()
    {
        players = new Player[playerSize];
        players[0].Color = gameGrid[0, 0];
        players[1].Color = gameGrid[gameGridRows - 1, gameGridCols - 1];
    }
}