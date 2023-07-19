namespace _10MetodosDeExtensao;

public static class StringExtensions
{
    public static string InverteString(this string str)
    {
        char[] charArray = str.ToCharArray(); //tranforma a string str em um array do tipo char pois é mais pratico usar o metodo Reverse
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
