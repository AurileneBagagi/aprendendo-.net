Console.WriteLine("Questão 3 do exercicio de Tratamento de exceção");

try {
    Console.WriteLine("Digite uma mensagem");
    string input = Console.ReadLine();
    if (input == null)
        throw new NullReferenceException("A entrada não pode ser nula");
    if (input.Length == 0)
        throw new ArgumentException("A entrada não pode está vazia");
    Console.WriteLine($"mensagem: {input}");
}
catch (NullReferenceException e){
    Console.WriteLine("Erro: "+e.Message);
}
catch (ArgumentException e){
    Console.WriteLine("Erro: "+e.Message);
}
catch (Exception e){
    Console.WriteLine("Erro Inesperado");
}
finally{
    Console.WriteLine("\nProcesso Finalizado...");
}