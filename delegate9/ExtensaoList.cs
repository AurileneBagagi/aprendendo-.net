namespace delegate9;
public static class ExtensaoList
{
    public static int SomaImpares(this List<int> lista)
    {
        int soma = 0;
        foreach (var item in lista)
        {
            // Action<int> action = (item) => { if (item % 2 != 0) soma += item ;};
            // action(item);
            if (item%2 != 0)
                soma+=item;
        }
        return soma;
    }
}