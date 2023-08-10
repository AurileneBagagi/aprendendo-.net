Console.Write("Digite o caminho do arquivo: "); 
string caminho = Console.ReadLine();
Console.Write("Digite o caminho da nova pasta: "); 
string copyCaminho = Console.ReadLine();

string nome = Path.GetFileName(caminho);
string newCopy = Path.Combine(copyCaminho, nome);
File.Move(caminho, newCopy);