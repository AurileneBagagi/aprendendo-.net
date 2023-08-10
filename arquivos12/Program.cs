// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Operador Ternario ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
Console.Write("Informe o valor de x: \n");
var x = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor de y: \n");
var y = Convert.ToDouble(Console.ReadLine());


var resultado = x >y? "x é maior que y": x<y? "x é menor que y": x==y? "x é igual a y": "sem resultado";
Console.WriteLine($"{resultado}");


