
Console.WriteLine("Informe o primeiro numero inteiro");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo numero inteiro");
int num2 = Convert.ToInt32(Console.ReadLine());

var soma = CalcularSoma(num1, num2).Result; //Como o resultado estára pronto de imediata pode usar resul no lugar do await, só que ele vai bloquear a thred principal até que ela seja concluido

Console.ForegroundColor= ConsoleColor.Yellow; //muda a cor do console 
Console.WriteLine($"\n {num1} + {num2}  = {soma}");

Console.ReadKey();

static async ValueTask<int> CalcularSoma(int num1, int num2)
{
    if (num1 == 0 && num2 == 0)
        return 0;

    return await Task.Run(() => num1+num2); //apenas para essa chamada aloca memoria// metodo assincrono 
}
