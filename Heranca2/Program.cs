using Heranca2;
// --------------------------------------------
Console.WriteLine("Exercicio2");

Carro carro = new Carro(0);

Console.WriteLine("Digite o valor a abastecer no carro: ");
int QuantidadeG = Convert.ToInt32(Console.ReadLine());

if (carro.Abastecer(QuantidadeG))
    carro.Dirigir();