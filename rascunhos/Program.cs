// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores de data");
Console.WriteLine();
//=============================== COMANDOS INTERESSANTES =======================================
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//criar uma data especifica 
DateTime dataesp = new DateTime(2023,02,18);
Console.WriteLine(dataesp);

//definindo as horas 
DateTime dataesph = new DateTime(2023,02,18,10,5,55);
Console.WriteLine(dataesph);

Console.ReadKey();