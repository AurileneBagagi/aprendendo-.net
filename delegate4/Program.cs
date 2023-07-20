Console.WriteLine("Questão 4 do Exercicio de Delegate,Lambda e LINQ");
List<int> list = new(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

Action<int> imprimir = (numero) => {if (numero%2==0) Console.WriteLine(numero);};
list.ForEach(imprimir);

Console.WriteLine("-----------------------------");

list.ForEach((numero) => {if (numero%2==0) Console.WriteLine(numero);});