namespace ConceptosBasicos
{
    public struct Estructura
    {
        public double X { get; }
        public double Y { get; }

        public Estructura(double x, double y) => (X, Y) = (x, y);
    }
}
