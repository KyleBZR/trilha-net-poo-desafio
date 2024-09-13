using DesafioPOO.Models;

// Implementado

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "28042006", modelo: "1132312", imei: "1712345", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");



Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "07011985", modelo: "441215", imei: "12441142", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");