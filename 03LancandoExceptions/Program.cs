try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();

class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em A");
        }    
    }
}
class B
{
    public static void ProcessarB()
    {

        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em B");
        }
      
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado"); //lançou/causou a exceção manualmente;
        // Ela vai retornar para a excução anterior para ser tratadada, caso a anterior não tenha tratamento, vai atras da anterior a anterior. Esse ciclo de retornar a pilha (stack) irá continuar até encontrar o tratamento do erro, ou que a pilha chegue ao fim e exibirá uma mensagem de erro.
    }
}
