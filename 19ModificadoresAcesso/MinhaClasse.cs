using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ModificadoresAcesso;

internal class MinhaClasse
{
    int MeuCampo; //privado, os valores só são permitido acesso no mesmo arquivo

    string? MinhaPropriedade { get; set; }  

    void MeuMetodo()
    {
        Console.WriteLine("Meu Metodo");
    }
}
