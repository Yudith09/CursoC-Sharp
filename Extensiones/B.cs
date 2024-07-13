using DefineIMyInterface;

namespace ExtensionMethodsDemo1;

public class B : IMyInterface
{
    public void MethodB() { Console.WriteLine("B.MethodB()"); }
    public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
}
