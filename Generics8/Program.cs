using System.Runtime.Serialization;

Console.WriteLine("Questão 8 do exercicio de Generics");

AddNumero<int> addNumero = new AddNumero<int>();

Console.WriteLine("Informe o primeiro número :"); 
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o segundo número :"); 
var y = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Resultado da adição: " + addNumero.Adiciona(x,y));

//A restrição de tipo where T : struct, IComparable, IConvertible, IFormattable é especificada para garantir que o tipo genérico T seja compatível com operações matemáticas
public class AddNumero<T> where T: struct, IComparable, IConvertible, IFormattable
{
    public T Adiciona(T x, T y){
        dynamic num1 = x; //O uso de dynamic permite que o compilador resolva o tipo do número em tempo de execução, permitindo que o método seja usado com qualquer tipo numérico estruturado.
        dynamic num2 = y;
        return num1+num2;

    }
}
