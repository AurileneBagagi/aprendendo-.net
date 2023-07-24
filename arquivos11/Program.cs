string caminho = @"C:\Users\auril\Downloads\projetos"; 
DirectoryInfo diretorio = new DirectoryInfo(caminho); 
foreach (var arquivo in diretorio.GetFiles("*", SearchOption.AllDirectories)) 
{ 
    Console.WriteLine(arquivo.FullName); 
}