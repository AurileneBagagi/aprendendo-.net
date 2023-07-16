//int
int i1 = 10;
int i2 = 10;
//float
float f1 = 10;
float f2 = 10;
//string
string s1 = "10";
string s2 = "10";

Console.WriteLine("------------------------------Generic classe----------------------------------");
Teste<int, int> teste1 = new Teste<int, int>(); // ao definir uma classe como generic é obrigatorio especificar o tipo  em sua instancia de objeto
Teste<float, float> teste2 = new Teste<float, float>();
Teste<string, string> teste3 = new();

teste1.Comparar(i1, i2);
teste2.Comparar(f1, f2);
teste3.Comparar(s1, s2);

Console.WriteLine("------------------------------Generic classe com restrição----------------------------------");
Testee<int, int> testeee = new Testee<int, int>(); // ao definir uma classe como generic é obrigatorio especificar o tipo  em sua instancia de objeto
Testee<float, float> testeee3 = new Testee<float, float>();
//Testee<string, string> testeee4 = new();

testeee.Comparar(i1, i2);
testeee3.Comparar(f1, f2);
//testeee4.Comparar(s1, s2);


Console.WriteLine("------------------------------Generic um valor---------------------------------");
Teste2 testee2 = new Teste2();
testee2.Comparar(i1,i2);
testee2.Comparar(f1, f2);
testee2.Comparar(s1, s2);

Console.WriteLine("------------------------------Generic dois valores----------------------------------");
Teste3 testee3 = new Teste3();
testee3.Comparar(i1,f2);
testee3.Comparar(f1, f2);
testee3.Comparar(s1, s2);

Console.ReadKey();
public class Teste<T1, T2> //definindo generic na classe 
{
    public void Comparar(T1 p1, T2 p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}");
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}

public class Testee<T1, T2> where T1 : struct  where T2 : struct//definindo generic na classe com restrição
{
    public void Comparar(T1 p1, T2 p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}");
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}

public class Teste2
{
    public void Comparar<T>(T p1, T p2) //com um tipo
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}");
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}

public class Teste3
{
    public void Comparar<T1, T2>(T1 p1, T2 p2) //com um tipo
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($" Os tipos : {p1.GetType()} e {p2.GetType()}");
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}