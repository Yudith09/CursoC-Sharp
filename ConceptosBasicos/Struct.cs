namespace ConceptosBasicos
{
    public struct Coords
    {
        public Coords(double x, double y) 
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        
        //Tipo de expresion unica
        public override string ToString() => $"{X}, {Y}"; 

        public readonly struct CoordsReadonly
        {
            public CoordsReadonly(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double X { get; init; }
            public double Y { get; init; }

            //Invalida los metodos de System 
            public readonly override string ToString() => $"({X}, {Y})";
        }

        public void Modificar()
        {
            var mo1 = new Coords(3, 0);
            
        }

        //Estructura record
        
    }
}
