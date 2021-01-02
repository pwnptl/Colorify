using static ColorifyColorEnum;
using UnityEngine;
public class ColorifyColor
{
    public static Color getColor(ColorifyColorEnum colorifyColor)
    {
        switch (colorifyColor)
        {
            case ColorifyColorEnum.White: return Color.white;
            case ColorifyColorEnum.Blue: return Color.blue;
            case ColorifyColorEnum.Yellow: return Color.yellow;
            case ColorifyColorEnum.Red: return Color.red;
            case ColorifyColorEnum.Green: return Color.green;
            case ColorifyColorEnum.Purple: return Color.magenta;
            case ColorifyColorEnum.Brown: return Color.gray;
            case ColorifyColorEnum.Cyan: return Color.cyan;
            default: return Color.clear;
        }
    }
}