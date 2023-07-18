B b = new B("Olá Mundo...");
b.Exibir();
Console.ReadKey();
class A
{
    String texto;
    public A(string s)
    {
        this.texto = s;
    }
    public void Exibir()
    {
        Console.Write(texto);
    }
}
class B : A
{
    public B(string s) : base(s)
    {
        Console.Write(s);
    }
}

//Neste código, a variável da classe base texto está sendo
//inicializada por meio do construtor de classe derivada
//usando a palavra-chave base.

//Assim o construtor da classe base vai atribuir o valor
//de s à variável texto

//Portanto, na criação do objeto com o parâmetro ‘Olá Mundo...’,
//essa string está disponível tanto para a classe base quanto
//para o corpo do construtor da classe derivada. 

//O resultado será a exibição no console do texto :
//‘Olá Mundo...’

