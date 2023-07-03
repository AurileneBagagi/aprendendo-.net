// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Operador Ternario ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
Console.Write("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp >27? "Quente": "Normal";
Console.WriteLine($" O tempo está {resultado}");


