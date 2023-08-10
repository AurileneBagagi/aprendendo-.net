Console.Write("Digite o caminho da pasta:"); 
string caminho = Console.ReadLine(); 
DirectoryInfo diretorio= new DirectoryInfo(caminho); //cria um objeto do tipo diretorio

foreach (var item in diretorio.GetDirectories()) // poderia também ter riado um DirectoryInfo[] ou uma var;
{
    Console.WriteLine(item.Name); //ler o nome dos arquivos/pasta
}
