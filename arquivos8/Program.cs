Console.Write("Digite o caminho da pasta: "); 
string caminho = Console.ReadLine(); 
Directory.CreateDirectory(caminho);

Console.Write("Digite o nome do arquivo +extenção:"); 
string NameArq = Console.ReadLine(); 
string arquivo = Path.Combine(caminho, NameArq);
File.Create(arquivo);