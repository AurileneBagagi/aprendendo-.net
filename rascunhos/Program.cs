// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores de data");
Console.WriteLine();
//=============================== COMANDOS INTERESSANTES =======================================
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//Extrair informações 
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.ToLongDateString());

//Adicionando valores na impressão 
Console.WriteLine(dataAtual.AddDays(1));
Console.WriteLine(dataAtual.AddHours(10));
Console.WriteLine(dataAtual);
Console.ReadKey();