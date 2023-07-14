using Heranca4;

Console.WriteLine(" ---- Exercicio4(3) ----");

Pessoa[] pessoas = new Pessoa[3];
for (int i = 0; i < 3; i++){
    if (i == 0){
        Console.WriteLine("Informe o nome do professor");
        pessoas[i] = new Professor(Console.ReadLine());
    }
    else{
        Console.WriteLine("Informe o nome do Aluno");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}

for (int i = 0; i < 3; i++){
    if (i == 0){
        ((Professor)pessoas[i]).Explicar(); //Como está em uma lista, é importante a coverção downcasting primeiro
    }
    else{
        ((Aluno)pessoas[i]).Estudar();
    }
}