﻿
using System.Net.Http.Json;

try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");
    Console.WriteLine("Informe o nome do arquivo.");
    string? arquivo = Console.ReadLine();
    Console.WriteLine("Informe a url do site.");
    string? url = Console.ReadLine();
    Console.WriteLine("\nAguarde...");

    HttpClient client = new HttpClient();
    //requisição get
    HttpResponseMessage response = client.GetAsync(url + "/"+ arquivo).Result; // o getAsync é usado para passar a url, eviar a informação de forma assincrona.
    // o metodo result é usado para aguardar resposta antes de continuar a execução 

    if(response.IsSuccessStatusCode) //indica se o request foi processado
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso");
        Console.WriteLine("Código de status : " + response.StatusCode);
    }
    else
    {
        throw new HttpRequestException("Erro : " + (int)response.StatusCode); //lançando um erro convertendo a resposta para um int
    }
}
catch(HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine(" Erro : " + ex.Message);
}
finally
{
    Console.WriteLine("Processamento concluido");
}

Console.ReadKey();