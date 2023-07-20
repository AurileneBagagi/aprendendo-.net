Console.WriteLine("Questão 3 do Exercicio de Delegate,Lambda e LINQ");

MensagemBoasVindas mensagem = MensagemPortuges;
mensagem+=MensagemIngles;
mensagem.Invoke();

static void MensagemPortuges()
{
    Console.WriteLine("Bem-Vindo!");
}
static void MensagemIngles()
{
    Console.WriteLine("Welcome!");
}

delegate void MensagemBoasVindas();
