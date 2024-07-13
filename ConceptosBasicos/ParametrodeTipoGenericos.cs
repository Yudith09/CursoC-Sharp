namespace ConceptosBasicos
{
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);

        
    }

   /* public int DevueveParametro()
    {
        var pair = new Pair<int, string>(1, "string");
        int i = pair.First;

        return i;
    }*/
}
