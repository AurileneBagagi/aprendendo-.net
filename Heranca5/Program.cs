using Heranca5;
Console.WriteLine(" ---- Exercicio5(4) ----");

Pessoa[] pessoas = new Pessoa[3];
for (int i = 0; i < 3; i++){
    Console.WriteLine("Informe o nome da pessoa");
    pessoas[i] = new(Console.ReadLine());
}
Console.WriteLine(" \n---- ----\n");
for (int i = 0; i < 3; i++){
    Console.WriteLine(pessoas[i].ToString());
}
