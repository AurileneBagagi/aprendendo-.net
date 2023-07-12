using Heranca;

Console.WriteLine(" ------ Atribuindo valores  de propriedades ------\n");

ContaCorrente contaCorrente = new ContaCorrente() { Nome = "Maria", Numero = 111}; //alternativa para instanciar objeto
ContaPoupanca contaPoupanca= new ContaPoupanca() { Nome = "Fabio", Numero=222};
ContaInvestimento contaInvestimento= new ContaInvestimento() { Nome = "Ana", Numero=333};


contaCorrente.Exibir();
contaPoupanca.Exibir();
contaInvestimento.Exibir();

Console.WriteLine("\n ------ Adicionando R$1000 a cada conta ------\n");
contaCorrente.Depositar(1000.00m);
contaPoupanca.Depositar(1000.00m);
contaInvestimento.Depositar(1000.00m);

contaCorrente.Exibir();
contaPoupanca.Exibir();
contaInvestimento.Exibir();

Console.WriteLine("\n ------ Sacando R$100 de cada conta ------\n");
contaCorrente.Sacar(100.00m);
contaPoupanca.Sacar(100.00m);
contaInvestimento.Sacar(100.00m);

contaCorrente.Exibir();
contaPoupanca.Exibir();
contaInvestimento.Exibir();

Console.WriteLine("\n ------ Sacando R$2000 de cada conta ------\n");
contaCorrente.Sacar(2000.00m);
contaPoupanca.Sacar(2000.00m);
contaInvestimento.Sacar(2000.00m);

contaCorrente.Exibir();
contaPoupanca.Exibir();
contaInvestimento.Exibir();
