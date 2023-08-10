Console.WriteLine("Exercicio de Tratamento de Erros: Questão 5\n");

try
{
    int[]numeros ={109, 211, 313, 405, 519, 617, 711, 891, 951, 1001};
    Console.WriteLine("Array:");
    foreach (var item in numeros)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine("\n\nDigite um indice do Array:");
    int indice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"O indice {indice} é o numero {numeros[indice]}");
}
catch (Exception e) when (e is IndexOutOfRangeException || e is ArgumentNullException) 
{
    Console.WriteLine("Erro: "+e.Message);
}
finally
{
    Console.WriteLine("\nProcesso Finalizado...");
}
