namespace Genericos1;

public class GenericList<T>()
{
    public void Add(T input) { }

    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            GenericList<string> list = new GenericList<string>();
            list.Add("a");
            GenericList<int> list2 = new GenericList<int>();
            list2.Add(1);
            GenericList<ExampleClass> generic = new GenericList<ExampleClass>();
            generic.Add(new ExampleClass());
        }
    }
}
