
string caminhoArquivo = @"C:\Users\auril\Documents\developer\github\aprendendo-.net\ArquivosLocalizacao\txt";

// tem que deixar fora, se não ele só vai existir dentro do try
//FileStream fs = null;
StreamReader leitor = null;

try
{
	//fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
	//criando um streamReader direto da classe File
	leitor = File.OpenText(caminhoArquivo); //new StreamReader(fs);

	string? linha;
	while((linha = leitor.ReadLine()) != null) // enquando eu estiver usando o leitor readline para ler a linha e isso for diferente de null, significa que eu ainda tenho linha para ler
	{
		Console.WriteLine(linha);
	}
}
catch(IOException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
	if (leitor != null) leitor.Close();
	//if (fs != null) fs.Close();
}
Console.ReadKey();
