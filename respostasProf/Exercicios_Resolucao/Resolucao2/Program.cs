
LivroFotos meuAlbum1 = new LivroFotos();
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum1.GetNumeroPaginas());
Console.Write(" páginas\n");

LivroFotos meuAlbum2 = new LivroFotos(24);
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuAlbum2.GetNumeroPaginas());
Console.Write(" páginas\n");

SuperLivroFotos meuSuperAlbum1 = new SuperLivroFotos();
Console.Write("Criando um Livro de fotos com ");
Console.Write(meuSuperAlbum1.GetNumeroPaginas());
Console.Write(" páginas\n");

Console.ReadLine();
public class LivroFotos
{
    protected int numeroPaginas;

    public LivroFotos()
    {
        numeroPaginas = 16;
    }

    public LivroFotos(int numeroPaginas)
    {
        this.numeroPaginas = numeroPaginas;
    }

    public int GetNumeroPaginas()
    {
        return numeroPaginas;
    }
}
public class SuperLivroFotos : LivroFotos
{
    public SuperLivroFotos()
    {
        numeroPaginas = 64;
    }
}