using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone1 = new Iphone("(11)98758-4733");
iphone1.Apresentar("Iphone 15 Pro Max","EK1234W",1024);
Console.WriteLine($"\n----- Iniciando testes Apple...\n");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Apple Store...");
Console.WriteLine($"----- Teste Apple finalizados com sucesso...\n");


Nokia nokia1 = new Nokia("(43)93658-4325");
nokia1.Apresentar("C21", "ET1245B",128);
Console.WriteLine($"\n----- Iniciando testes Nokia...\n");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("PlayStore...");
Console.WriteLine($"----- Teste Nokia finalizados com sucesso...\n");




