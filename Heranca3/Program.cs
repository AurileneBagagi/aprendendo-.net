// --------------------------------------------
using Heranca3;

Console.WriteLine(" ---- Exercicio3 ----");

Console.Write("Criando um album de fotos com: ");
LivroFotos fotospadrao = new LivroFotos();
Console.WriteLine($"{fotospadrao.GetNumeroPaginas} páginas");

Console.Write("Criando um album de fotos com: ");
LivroFotos fotospadrao2 = new LivroFotos(24);
Console.WriteLine($"{fotospadrao.GetNumeroPaginas} páginas");

Console.Write("Criando um album de fotos grande com: ");
SuperLivroFotos grande = new();
Console.WriteLine($"{grande.GetNumeroPaginas()} páginas");