Console.Write("Digite o caminho da pasta:"); 
string caminho = Console.ReadLine(); 
string[] diretorio = Directory.GetFiles(caminho);

foreach (var item in diretorio)
{
    Console.WriteLine(Path.GetFileName(item)); //ler o nome dos arquivos/pasta
}

