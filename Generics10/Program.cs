Console.WriteLine("###### Questão 10 do exercicio de Generics ######");

// implemente um programa que verifica se uma expressão matemática contém parênteses balanceados 
// seguindo os seguintes passos: 
// 1. Crie uma variável do tipo Stack<char> para armazenar os parênteses abertos. 
// 2. Percorra cada caractere da expressão matemática. 
// 3. Se o caractere for um parêntese aberto ( '(', '{', '['), adicione-o à pilha. 
// 4. Se o caractere for um parêntese fechado ( ')', '}', ']' ), verifique se a pilha não está vazia e se o último 
// parêntese aberto adicionado na pilha corresponde ao parêntese fechado atual. Se sim, remova o 
// último parêntese aberto da pilha. Caso contrário, a expressão matemática não contém parênteses 
// balanceados. 
// 5. Após percorrer todos os caracteres da expressão matemática, verifique se a pilha está vazia. Se estiver 
// vazia, a expressão matemática contém parênteses balanceados. Caso contrário, a expressão não é 
// balanceada. 

Console.WriteLine("Digite a expressão matematica");
var expressao = Convert.ToString(Console.ReadLine());

bool resultado = VerificaEspressao(expressao);
Console.WriteLine($"A expressão: \"{expressao}\" {(resultado? "contem": "não contem")} simbolos balanceados");

static bool VerificaEspressao(string? expressao)
{
    Stack<char> par = new Stack<char>();

    foreach (var i in expressao)
    {

        if (i == '(' || i == '{' || i == '[')
            par.Push(i);
        else if (i == ')' || i == '}' || i == ']')
        {
            if (par.Count == 0)
            {
                return false;
            }

            char ultimo = par.Pop();
            // se i for ), e o ultimo simbolo não for seu correspondente (, então é desbalanceado 
            if ((ultimo != '(' && i == ')') || (ultimo != '[' && i == ']') || (ultimo != '{' && i == '}'))
            {
                return false;
            }
        }
    }
    return par.Count == 0;
}

