string caminho = @"C:\Users\auril\Downloads\Exercicio.txt";

/* comentarios: 
using FileStream fileStream= new FileStream(caminho, FileMode.Create, FileAccess.ReadWrite);
// O using não foi fnalizado, logo o writer deve receber o objeto fileStream 
using StreamWriter writer = new StreamWriter(fileStream);*/

using (FileStream fileStream = new FileStream(caminho, FileMode.Create))
{
    Console.WriteLine($"O arquivo {fileStream.Name} foi criado");
}
using (StreamWriter writer = new StreamWriter(caminho,true))
{
    writer.WriteLine("Olá,\r\nEu sou a Aurilene, criadora deste arquivo");
}
using (StreamWriter writer = File.AppendText(caminho))
{
    writer.WriteLine("estou testando-o");
}
using (StreamReader streamReader = File.OpenText(caminho)) 
{ 
    string conteudo = streamReader.ReadToEnd(); 
    Console.WriteLine(conteudo); 
}
File.Delete(caminho);