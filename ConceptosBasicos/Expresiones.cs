namespace ConceptosBasicos
{
    public class Expresiones
    {
        public void EjemplosExpresiones()
        {
            //Expresiones de interoperabilidad 
            var r = 2.3;
            var message = $"The area of a circle with radius {r} is {Math.PI * r * r:F3}.";
            Console.WriteLine(message);
            // Output:
            // The area of a circle with radius 2.3 is 16.619.

            //Expresiones Lambda
            int[] numbers = { 2, 3, 4, 5 };
            var maximumSquare = numbers.Max(x => x * x);
            Console.WriteLine(maximumSquare);
            // Output:
            // 25

            //Expresiones de consultas 

            int[] scores = { 90, 97, 78, 68, 85 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Console.WriteLine(string.Join(" ", highScoresQuery));
            // Output:
            // 97 90 85
        }


    }

}
