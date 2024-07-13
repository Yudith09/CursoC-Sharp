// See https://aka.ms/new-console-template for more information
using Genericos1;

Console.WriteLine("Hello, World!");


// int is the type argument
GenericList<int> list = new GenericList<int>();

for (int x = 0; x < 10; x++)
{
    list.Add(x);
}
Console.WriteLine("\nDone");

class TestGenericList
{
    private class ExampleClass { }
    static void Main()
    {
        // Declare a list of type int.
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);

        // Declare a list of type string.
        GenericList<string> list2 = new GenericList<string>();
        list2.Add("");

        // Declare a list of type ExampleClass.
        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());        
    }
}