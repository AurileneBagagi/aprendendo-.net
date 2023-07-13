namespace _15Composicao;

internal class Migrador
{
    public DateTime DataHora { get; set; }

    private readonly Logger _logger; // a propriedade é privada e somente leitura para não poder ser alterada após recever a instancia a instancia no momento

    public Migrador(Logger logger)
    {
        _logger = logger;
    }

    public void Migrar()
    {
        _logger.Log($"Migrando em : {DataHora}");
    }

}
