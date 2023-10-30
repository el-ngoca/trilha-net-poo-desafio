using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Iphone
Console.WriteLine($"Inicializando o Iphone");
Console.WriteLine($"\n");
Iphone Ip8 = new(numero:"1234",modelo:"Iphone 8",imei:"87476625525",memoria:65);
Ip8.Ligar();
Ip8.InstalarAplicativo("Whatsapp");
Console.WriteLine($"\n");

///Andoid
Console.WriteLine($"Inicializando O Android");
Console.WriteLine($"\n");
Nokia Galaxy = new(numero:"7376636",modelo:"S5",imei:"908796574",memoria:78);
Galaxy.Ligar();
Galaxy.InstalarAplicativo("Whatsapp");