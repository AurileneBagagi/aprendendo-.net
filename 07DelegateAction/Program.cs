using System;

Console.WriteLine("Informe um número inteiro :");
int numero = Convert.ToInt32(Console.ReadLine());
//Delegate que não retorna nenhum valor e pode receber de um a 16 argumentos do tipop t, é do tipo void (pesquisar se não pode receber nenbhum valor);
//é usado para callbacks
Action<int> dobra = x => Console.WriteLine(x * 2);
dobra(numero);

Console.ReadKey();

