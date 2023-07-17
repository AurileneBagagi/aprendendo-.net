Console.WriteLine("###### Questão 11 do exercicio de Generics ######");

Queue<string> fila = new Queue<string>();
fila.Enqueue("Arquivo PDF.pdf");
fila.Enqueue("Arquivo DOC.docx");
fila.Enqueue("Arquivo PNG.png");

do{
    if(fila.Count == 0)
        break;
    string imprimindo = fila.Dequeue();
    Console.WriteLine($"\nImprimindo o Arquivo \"{imprimindo}\"\n...");

    Thread.Sleep(new Random().Next(1000,6000)); //outra forma usar o random
    Console.WriteLine($"\nO Arquivo \"{imprimindo}\" foi impresso com sucesso");

}
while (true);