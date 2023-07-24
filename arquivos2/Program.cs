Console.Write("Bem Vindo!\nDigite o caminho original do arquivo: ");
string caminho = Console.ReadLine();
Console.WriteLine("\n"+caminho);
Console.Write("\nDigite o caminho da cópia do arquivo arquivo: ");
string caminho2 = Console.ReadLine();


// if (File.Exists(caminho))
// {
//     FileInfo fileInfo = new FileInfo(caminho);
//     fileInfo.CopyTo(caminho2);
//     Console.WriteLine($"O arquivo {fileInfo.Name} foi copiado para {caminho2}");
// }
// else
//  Console.WriteLine("O arquivo não existe!");

string nomeArquivo = Path.GetFileName(caminho); 
string caminhoDestinoCompleto = Path.Combine(caminho2, nomeArquivo); 
File.Copy(caminho, caminhoDestinoCompleto, true); 
Console.WriteLine("Arquivo copiado com sucesso.");