

namespace Heranca3;

public class LivroFotos
{
    protected int numPagina ;
    public LivroFotos(){
        numPagina = 16;
    }
    public LivroFotos(int numero){
        numPagina = numero;
    }
    public int GetNumeroPaginas=> numPagina;

}