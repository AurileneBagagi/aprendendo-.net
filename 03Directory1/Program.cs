var caminhoDiretorio = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\MeuDiretorio";
string caminhoDestino = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\MeuDiretorioNovo";
var caminhoDiretorio2 = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\MeuDiretorioNovo\teste";
var caminho = @"C:\Users\auril\Documents\developer\github\aprendendo-.net";


Console.WriteLine("\nInteragindo com diretórios");

try
{
    if(Directory.Exists(caminhoDiretorio))
    {
        Console.WriteLine(Directory.GetCurrentDirectory()); //diretorio da pasta aberta no vscode
        Directory.Move(caminhoDiretorio, caminhoDestino);
        Console.WriteLine("Diretório renomeado(movido) com sucesso!");
        Directory.CreateDirectory(caminhoDiretorio2);
        Console.WriteLine($"Diretório {caminhoDiretorio2} criado com sucesso!");
        Directory.Delete(caminhoDiretorio2);
        Console.WriteLine($"Diretório {caminhoDiretorio2} apagado com sucesso!");
        string[] pastas = Directory.GetDirectories(caminho);
        Console.WriteLine("\n ----- Subditerorio do Diretorio aprendendo-.net -----\n");
        Exibir(pastas);
        Console.WriteLine("\n ----- Subditerorio com A do Diretorio aprendendo-.net -----\n");
        string[] pastasA = Directory.GetDirectories(caminho, "A*");
        Exibir(pastasA);
        Console.WriteLine("\n ----- Arquivos do Diretorio aprendendo-.net -----\n");
        string[] result = Directory.GetFiles(caminho);
        Exibir(result);

    }
    else
    {
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine($"Diretório {caminhoDiretorio} criado com sucesso!");
    }
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

static void Exibir(string[] lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}