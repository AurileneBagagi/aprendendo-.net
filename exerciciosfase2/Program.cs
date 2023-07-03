Console.WriteLine(" ============== Execicios Fase 2 - Fundamentos ============");
//OBC.: as variaveis com C no final indica o correto do exercicio
/*
// ------------------------------------------
Console.WriteLine("\nQuestão 1");
string nome = "Paulo";
int idade = 17;
double nota = 7.5;
// com concatenação
Console.WriteLine("Aluno "+nome+ " tem "+idade+" anos e a nota "+nota);
// com interpolação
Console.WriteLine($"Aluno {nome} tem {idade} anos e a nota {nota}");
// ------------------------------------------
Console.WriteLine("\nQuestão 2");
Console.WriteLine($"Aluno: {nome}\nIdade: {idade}\nNota {nota}");
// ------------------------------------------
Console.WriteLine("\nQuestão 5");
char letra1, letra2, letra3;
Console.Write("Digite a primeira letra: ");
letra1 = Convert.ToChar(Console.ReadLine());
Console.Write("Digite a segunda letra: ");
letra2 = Convert.ToChar(Console.ReadLine());
Console.Write("Digite a terceira letra: ");
letra3 = Convert.ToChar(Console.ReadLine());
// com concatenação
Console.WriteLine("letra 3: "+letra3+", letra 2: "+letra2+ ", letra 1: "+letra1);
// com interpolação
Console.WriteLine($"Letra 3: {letra3}, Letra 2: {letra2}, Letra 1: {letra1}");
// ------------------------------------------
Console.WriteLine("\nQuestão 7");
double x,y;
Console.WriteLine("Digite o valor de x:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Soma = {x+y}");
Console.WriteLine($"Subtração = {x-y}");
Console.WriteLine($"Multiplicação = {x*y}");
Console.WriteLine($"Exponenciação = {Math.Pow(x,y)}");
Console.WriteLine($"Divisão = {x/y}");
Console.WriteLine($"Modulo = {x%y}");
// ------------------------------------------
Console.WriteLine("\nQuestão 8");
int a = 1;
int b= 12;
int c= -13;
double delta =  Math.Pow(b, 2) - 4*a*c;
double x1 = (-b+Math.Sqrt(delta))/2*a;
double x2 = (-b-Math.Sqrt(delta))/2*a;
Console.WriteLine($"resultado de x1={x1} e x2={x2}");
// ------------------------------------------
Console.WriteLine("\nQuestão 9");
Console.WriteLine("Digite o nome: ");
string? nome = Convert.ToString(Console.ReadLine());
Console.WriteLine("Digite a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());
string resultados  = (nome == "admin" || nome == "maria") && (senha == 123) ? "Login feito com sucesso": "Login Invalido";
Console.WriteLine(resultados);
// ------------------------------------------
Console.WriteLine("\nQuestão 11");
Console.WriteLine("Digite o numero x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o numero y: ");
int y = Convert.ToInt32(Console.ReadLine());
string resultado1 = (x%2 == 0) ? "X é par": "X é impar";
string resultado2 = (y%2 == 0) ? "Y é par": "Y é impar";
Console.WriteLine(resultado1 + " e " + resultado2); 
// ------------------------------------------
Console.WriteLine("\nQuestão 12");
Console.WriteLine("Digite o numero x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"PI*(x^2) = {Math.PI*(Math.Pow(x,2))}");
// ------------------------------------------ 
Console.WriteLine("\nQuestão 13");
int y = 5;
y = (y++)+y+(++y);
Console.WriteLine(y);
// ------------------------------------------ 
Console.WriteLine("\nQuestão 14");
Console.WriteLine("Digite o graus celsius: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Temperatura em Kelvin = {c+273}");
Console.WriteLine($"Temperatura em Farhenheit = {((c*9)/5)+32}");*/
// ------------------------------------------ 
Console.WriteLine("Saciando algumas dúvidas");
var nome = "Nome";
Console.WriteLine(nome);
string resultado = 100.ToString();// convertendo o numero 100 em string
Console.WriteLine(resultado);
Console.WriteLine(nome.GetType());
var numero = -12.0;
Console.WriteLine(numero);
Console.WriteLine(numero.GetType());
object o= 12.45m;
Console.WriteLine(o.GetType());
decimal valor = (decimal) 10.99f;
Console.WriteLine(valor.GetType());