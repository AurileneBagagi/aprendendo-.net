Console.WriteLine("Questão 4 do exercicio de Tratamento de exceção");

string nome = null;
try
{
    Console.WriteLine("Digite a sua idade");
    int idade = Convert.ToInt32(Console.ReadLine());
    if (idade <0)
        throw new ArgumentException("A idade não pode ser negativa");
    else if (idade == 0)
        throw new NotImplementedException("A idade ainda não foi definida");

    Console.WriteLine("Digite o seu nome");
    nome = Console.ReadLine();
    if (nome == null)
        throw new NullReferenceException("O nome não pode ser nulo");
    
}
catch (ArgumentException e)
{
    Console.WriteLine("Erro: "+e.Message);
}
catch (NotImplementedException e)
{
    Console.WriteLine("Erro: "+e.Message);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Erro: "+e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro Inesperado: "+e.Message);
}
finally
{
    Console.WriteLine("\nProcesso finalizado...");
}