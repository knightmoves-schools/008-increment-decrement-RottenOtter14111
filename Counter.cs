namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;

    public int PrefixIncrement
    {
        get
        {
            Visitors = 100;
            return ++Visitors;
        }
    }

    public int PostfixIncrement
    {
        get
        {
            Visitors = 100;
            return Visitors++;
        }
    }

    public int PrefixDecrement
    {
        get
        {
            Visitors = 100;
            return ++Visitors;
        }
    }

    public int PostfixDecrement
    {
        get
        {
            Visitors = 100;
            return Visitors++;
        }
    }
}
