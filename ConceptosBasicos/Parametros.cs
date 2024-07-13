namespace ConceptosBasicos
{
    public class Parametros
    {
        //Parametros de referencias
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }

        //Parametros de salidas 
        static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }

        public static void OutUsage()
        {
            Divide(10, 3, out int quo, out int rem);
            Console.WriteLine($"{quo} {rem}");  // "3 1"

            int x, y, z;
            x = 3;
            y = 4;
            z = 5;
        }
    }
}
