using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "A155", imei: "123555", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123789", modelo: "SE2", imei: "789789", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("-------------------------------------------------");