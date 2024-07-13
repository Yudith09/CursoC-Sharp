namespace ConceptosBasicos
{
    public class Point3D: Point
    {
        public int Z {  get; set; }

        public Point3D(int x, int y, int z) : base(x, z)
        {
            Z = z;
        }
    }
}
