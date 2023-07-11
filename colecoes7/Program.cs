// ------------------------------------------
Console.WriteLine("Questão 7");
Aluno aluno = new Aluno();

aluno[0] = "Aurilene";
aluno[1] = "Pablo";
aluno[2] = "Dhony";
aluno[3] = "Maria";
aluno[4] = "Jóse";
aluno[5] = "Zé";
aluno[6] = "Diorgenes";
aluno[7] = "Amanda";
aluno[8] = "Lara";
aluno[9] = "Joana";

Console.WriteLine("Obtendo todos os valores");
for (int i = 0; i < 10; i++)
{
    Console.Write(aluno[i]+", ");
}

public class Aluno
{
    string[] nome = new string[10];

    public string this[int i] {
        get{
            if (i>=0 && i<nome.Length)
                return nome[i];
            else 
                return "Erro";
        }
        set{
            if (i>=0 && i<nome.Length)
                nome[i]=value;
        }
    }
}
