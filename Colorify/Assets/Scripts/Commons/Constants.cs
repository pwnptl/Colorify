using static ColorifyColorEnum;
using static Player;
using UnityEngine;
public class Constants
{
    // constructor is private for now. 
    private Constants() { }

    // All constants are const/static so far.
    public const int playerSize = 2;
    public const int gameGridRows = 16;
    public const int gameGridCols = 24;
    public const int colorsAvailable = 4;

    // All methods to be static. 
    // TODO
    public static void logMethod()
    {   
        string debugString = "";
        debugString += "Executing ";
        //debugString += this.GetType().Name + " : ";
        //debugString += System.Reflection.MethodBase.GetCurrentMethod().Name;
        
        Debug.Log(debugString);
    }

    
}