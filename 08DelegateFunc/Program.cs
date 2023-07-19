
Console.Write("Digite um número : ");
double numero = Convert.ToDouble(Console.ReadLine());
//Delegate que retorna algum valor e pode receber de 0 a 16 argumentos do tipop t
Func<double, double> raizQuadrada =Math.Sqrt; //forma reduzida, mas a expressão lambida é mais coveniente

var resultado = raizQuadrada(numero);

Console.WriteLine("\nA raiz quadrada de " + numero + " é : " + resultado);

Console.ReadKey();

