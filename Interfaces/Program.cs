using Interfaces;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

Isalvar salvarArquivoJ = new SalvarJson();
salvarArquivoJ.Compactar();
