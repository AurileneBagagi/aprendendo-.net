// ------------------------------------------
using System.Collections;

Console.WriteLine("Questão 6");

ProcessaObjeto(1, "Maria", 3.45m, new Teste(), null);

static void ProcessaObjeto(params object[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine($"Valor: {item}\tTipo: {item?.GetType()}");
        
    }
}
class Teste{}

//Estamos usando GetType() herdado de Object
            // E usamos o operador ? conhecido como “null-conditional operator”
            // ou elvis operator, que determina se valor é null; se assim for,
            // o método GetType() não será invocado e não teremos exceção
            // NullReferenceException.