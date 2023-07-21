
string caminhoOrigem = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\primeiro.txt";
string caminhoDestino = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\txt\primeiro.txt";


if (!File.Exists(caminhoDestino)) //verifica se o arquivo já existe
{
    try
    {
        //Criar arquivo, sem o .Close() o arquivo fica aberto
        File.Create(caminhoOrigem).Close();
        //Abre o arquivo, se o arquivo não existir ele cria, Escreve no arquivo, e fecha o arquivo
        File.WriteAllText(caminhoOrigem, "Aurilene Bagagi \r\n\r\n");  //\r\n é para pular linha no arquivo

        string novoTexto = "O poeta é um fingidor " +
                            Environment.NewLine + //pula linha
                           "Finge tão completamente\r\n" +
                           "Que chega a fingir que é dor\r\n" +
                           "A dor que deveras sente.\r\n";

        //Abre o arquivo, se o arquivo não existir ele cria, anexa uma string, e fecha o arquivo
        File.AppendAllText(caminhoOrigem, novoTexto);

        // lê o conteúdo do arquivo
        Console.WriteLine("\nConteúdo e informações do arquivo : ");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        Console.WriteLine($"Última modificação feita em : {File.GetLastWriteTime(caminhoOrigem)}");
        Console.WriteLine($"Último acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");

        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (var linha in linhas)
            Console.WriteLine(linha);

        var caminhoCopia = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\primeiro_copia.txt";
        Console.WriteLine($"\nCopiando de {caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);


        Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        //excluir
        Console.WriteLine($"\nExcluindo {caminhoOrigem} , {caminhoDestino} e {caminhoCopia}");
        File.Delete(caminhoOrigem);
        //File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Concluido");

Console.ReadKey();










