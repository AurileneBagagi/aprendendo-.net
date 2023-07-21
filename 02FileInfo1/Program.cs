﻿
var caminhoOrigem = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\poesia.txt";
var caminhoDestino = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\txt\poesia.txt";
var caminhoCopia = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\poesia_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem); //instancia da classe FileInfo

Console.WriteLine("\nNome do arquivo: " + arquivoOrigem.Name);

Console.WriteLine("\nCaminho completo do arquivo: " + arquivoOrigem.FullName); //cami

Console.WriteLine("\nO arquivo é somente leitura: " + arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("\nNome do diretório: " + diretorioPai.Name);

Console.WriteLine("Tamanho do arquivo: " + arquivoOrigem.Length + " bytes");


Console.WriteLine("\nÚltima gravação: " + arquivoOrigem.LastWriteTime);

if(arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo não existe.");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para a {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);

Console.ReadKey();