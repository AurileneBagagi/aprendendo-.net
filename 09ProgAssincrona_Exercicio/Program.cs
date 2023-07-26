await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //criar um CancellationTokenSource
    var tempo = 20;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

    try
    {
        using var httpClient = new HttpClient();
        var destino = "d:\\dados\\arquivo.txt";

        var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);
        //HttpCompletionOption.ResponseHeadersRead: a resposta do servidor deve ser lida por partes, reduzindo o tempo e a memoria

        var totalBytes = response.Content.Headers.ContentLength; //tamanho do arquivo
        var readBytes = 0L; //o quanro o programa já leu

        //o await que dizer que vai esperar até que a execução seja concuida
        //usig será liberado da memoria assim que terminar o uso
        await using var fileStream = new FileStream(destino, FileMode.Create,
                                                             FileAccess.Write); //deve ser aberto no modo de gravação

        // recebe os dados de response
        await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);
         // ReadAsStreamAsync: retorna um fluxo de dados como string, no caso, o get link
         
        var buffer = new byte[81920];
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length,
            cancellationTokenSource.Token)) > 0) //enquanto tiver dados para lê
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token); //escrevendo no arquivo 
            readBytes += bytesRead;
            Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
        }
    }
    catch (OperationCanceledException ex)
    { //é lançada quando uma operação assincrina é cancelada antes de ser concluida
        if (cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado por tempo limite : " + ex.Message);
        }
        else
        {
            Console.WriteLine("\nO tempo limite para o download foi atingido.");
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("\nDownload finalizado.");
    }
}
