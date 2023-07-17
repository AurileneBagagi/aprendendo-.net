namespace _14StackUndo;

public class EditorTexto
{
    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto : {texto}");
    }

    public void Undo()//desfazendo a ultima alteração
    {
        if(undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0,texto.Length - 1); //Esse método é usado para extrair uma sub cadeia de caracteres de uma string. Ele recebe dois parâmetros o índice inicial da substring e o comprimento da substring que eu quero extrair
            Console.WriteLine($"Texto : {texto}");
        }
    }

}
