A a = new A();
B b = new B();
A x;
x = a;
x.Exibir();
x = b;
x.Exibir(); 


class B: A 
{
public override void Exibir() 
{
Console.WriteLine("B"); } 
}

class A
{
public virtual void Exibir() 
{
Console.WriteLine("A"); 
} 
}