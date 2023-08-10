using System; 
using System.IO; 
//C:\Users\auril\OneDrive\Imagens\Background\bloqueio.jpg
//C:\Users\auril\Downloads\Exercicio.txt

Console.WriteLine("Digite o caminho do arquivo de imagem:"); 
string imagePath = Console.ReadLine(); 
Console.WriteLine("Digite o caminho do arquivo de destino:"); 
string textFilePath = Console.ReadLine(); 

// Lê o conteúdo do arquivo de imagem usado os bytes da mesma
byte[] imageBytes = File.ReadAllBytes(imagePath); 
// Converte o conteúdo para String de Base64 
string base64String = Convert.ToBase64String(imageBytes); 
// Escreve o conteúdo em um novo arquivo de texto 
File.WriteAllText(textFilePath, base64String); 
Console.WriteLine("Arquivo de texto salvo com sucesso!"); 
