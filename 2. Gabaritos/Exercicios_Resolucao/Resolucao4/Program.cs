
Database db = new SQLServer();
db.Configurar();
db.Conectar();

Console.ReadKey();

abstract class Database
{
    public virtual void Conectar()
    {
        Console.WriteLine("Conectando ao banco de dados...");
    }
    public abstract void Configurar();
}
class SQLServer : Database
{
    public void Conectar()
    {
        Console.WriteLine("Conectando ao SQL Server...");
    }

    public override void Configurar()
    {
        Console.WriteLine("Configurando o banco de dados...");
    }
}

//O método connect da classe SQLServer deve ser sobrescrito.
//Como o método Conectar da classe base abstrata é virtual,
//ele pode ser substituído na classe derivada.
//Ex: public override void Conectar()
