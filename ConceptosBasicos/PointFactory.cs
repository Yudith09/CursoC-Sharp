namespace ConceptosBasicos
{
    public class PointFactory(int numberOfPoints)
    {
        public IEnumerable<Point> CreatePoints()
        {
            var generator = new Random();
            for (int i = 0; i < numberOfPoints; i++)
            {
                yield return new Point(generator.Next(), generator.Next());
            }
        }

    }
}
