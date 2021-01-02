public class Player
{
    private string name;
    private ColorifyColorEnum color;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public ColorifyColorEnum Color
    {
        get { return color; }   // get method
        set { color = value; }  // set method
    }
    public Player()
    {
        name = "not_given";
        color = ColorifyColorEnum.White;
    }
    
}