namespace ConceptosBasicos;

public class Enum
{
    enum Seasson
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum ErrorCode: ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }

    //Banderas en enum 

    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }
}
