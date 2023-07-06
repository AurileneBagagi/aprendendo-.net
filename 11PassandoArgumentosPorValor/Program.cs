Console.WriteLine("## Passando argumentos por valor ##\n");
// o metodo tem acesso a cópia, modifca a cópia e depois ela é excluida ao fim do método

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

Console.ReadKey();  

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2; //y=y*2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}