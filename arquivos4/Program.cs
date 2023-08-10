using System.Security.Cryptography;
using System.Text;

//Console.Write("Digite o caminho do arquivo de origem: "); 
string caminhoOrigem = @"C:\Users\auril\Downloads\Exercicio.txt";
//Console.Write("Digite o caminho do arquivo de destino: "); 
string caminhoDestino = @"C:\Users\auril\Downloads\Exercicio - Copia.txt";  
//Console.Write("Digite a senha (16Caracteres) "); 
string chave = "Aurilene12351516";   
// Lê o conteúdo do arquivo 
string conteudo = File.ReadAllText(caminhoOrigem); 
// Criptografa o conteúdo com o algoritmo AES 
byte[] conteudoCriptografado; 
using (Aes aes = Aes.Create()) 
{ 
    aes.Key = Encoding.UTF8.GetBytes(chave); 
    aes.Mode = CipherMode.CBC; 
    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV); 
    using (MemoryStream memoryStream = new MemoryStream()) 
    { 
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, 
CryptoStreamMode.Write)) 
        { 
            using (StreamWriter streamWriter = new StreamWriter(cryptoStream)) 
            { 
                streamWriter.Write(conteudo); 
            } 
            conteudoCriptografado = memoryStream.ToArray(); 
        } 
    } 
} 
// Salva o conteúdo criptografado em um novo arquivo 
File.WriteAllBytes(caminhoDestino, conteudoCriptografado); 
Console.WriteLine("Arquivo criptografado com sucesso.");

