﻿Console.WriteLine("Informe um número inteiro :");
int numero = Convert.ToInt32(Console.ReadLine());
//retorna um valor boleano
Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero))
    Console.WriteLine($"O número {numero} é PAR");
else
    Console.WriteLine($"O número {numero} é ÍMPAR");

Console.ReadKey();