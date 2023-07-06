Console.WriteLine("## Passando argumentos por referência ##\n");
// o metodo tem acesso a chave de memoria x, cria um ponteiro até ela, modifica ela e ao fim o seu ponteir é excluido
int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2; //y=y*2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}

