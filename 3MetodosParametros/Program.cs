﻿Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse(); //poderia ter fornecido o valores diretamente nos parametros

var nomeCliente = "Aurilene";
var dataAtual = DateTime.Now.ToShortDateString();

//valores dos argumentos
minhaClasse.Saudacao(nomeCliente,dataAtual );

Console.ReadKey();

public class MinhaClasse
{
    //os parametros do metodo
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}