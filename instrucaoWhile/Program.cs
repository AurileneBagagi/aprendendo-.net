Console.WriteLine("=============== Instrução de Repetição While =================");
Console.WriteLine("Tabuada de um número");

int numero;
int contador =0;
Console.Write("Digite um número maior que zero: ");
numero = Convert.ToInt32(Console.ReadLine()); 
if (numero>0)
{
    //loop
    Console.WriteLine($"Tabuada de {numero}");
    while(contador <11)
    {
        Console.WriteLine($"{numero} * {contador} = {numero*contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("Número deve ser maior que zero!!");
}