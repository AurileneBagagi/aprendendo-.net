
Console.Write("Bem Vindo!\nDigite o caminho do arquivo: ");
string caminho = Console.ReadLine(); //não reconhece se tiver simbolos br

try
{
    if (File.Exists(caminho))
        {
            //FileInfo fileInfo = new FileInfo(caminho);
            Console.WriteLine("O arquivo foi criado em: "+File.GetCreationTime(caminho));
        }
    else
        Console.WriteLine("O arquivo não existe!");
}
catch (IOException e)
{
    Console.WriteLine("Error: " + e.Message);
}
