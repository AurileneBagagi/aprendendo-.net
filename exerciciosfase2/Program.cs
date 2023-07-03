Console.WriteLine(" ============== Execicios Fase 2 - Fundamentos ============\n");
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
Console.WriteLine("Digite a primeira letra: ");
letra1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite a segunda letra: ");
letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite a terceira letra: ");
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
Console.WriteLine($"resultado de x1={x1} e x2={x2}");*/
// ------------------------------------------
Console.WriteLine("\nQuestão 9");
Console.WriteLine("Digite o nome: ");
string? nome = Convert.ToString(Console.ReadLine());
Console.WriteLine("Digite a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());
string resultados  = (nome == "admin" || nome == "maria") && (senha == 123) ? "Login feito com sucesso": "Login Invalido";
Console.WriteLine(resultados);


