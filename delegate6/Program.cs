Console.WriteLine("Questão 6 do Exercicio de Delegate,Lambda e LINQ");

int x =5, y =3;
Func<int, int, int> operacao = (x, y) => x+y;
Console.WriteLine($"O resulado da operação de soma é {operacao(x,y)}");
operacao = (x, y) => x-y;
Console.WriteLine($"O resulado da operação de subtração é {operacao(x,y)}");

// Func<int, int, int> operacao2 = (x, y) => x+y;
// Console.WriteLine($"O resulado da operação de soma é {Operar(x, y, operacao2)}");
// operacao2 = (x, y) => x-y;
// Console.WriteLine($"O resulado da operação de subtração é {Operar(x, y, operacao2)}");

// static int Operar(int x, int y, Func<int, int, int> operacao2)
// {
//     return operacao2(x, y);
// }