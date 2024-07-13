// See https://aka.ms/new-console-template for more information
using Extensiones;
using ExtensionMethodsDemo1;
using Extensions;

Console.WriteLine("Hello, World!");

A a = new A();
B b = new B();
C c = new C();

a.MethodA(1);           
a.MethodA("hello");

a.MethodB();

b.MethodA(1);           
b.MethodB();

b.MethodA("hello");

c.MethodA(1);          
c.MethodA("hello");     
c.MethodB();
