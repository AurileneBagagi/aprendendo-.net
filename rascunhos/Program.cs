// See https://aka.ms/new-console-template for more information
Console.WriteLine("##Formatando a Saida de  dados ##\n");
//=============================== COMANDOS INTERESSANTES =======================================
int idade = 25;
string nome = "Maria";
Console.WriteLine("---------------- Concatenação -----------------");
Console.WriteLine(nome+" tem "+idade+" anos ");
Console.WriteLine("---------------- Interpolação -----------------");
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine("---------------- Place Holders -----------------");
Console.WriteLine("{0} tem {1} anos", nome, idade);