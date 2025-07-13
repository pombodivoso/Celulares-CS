using DesafioPOO.Models;

Nokia nokia = new Nokia("+55 44 98976-3656", "909092937465", 128, "Tijolo");
Iphone iphone = new Iphone("+55 41 97904-7653", "909092937466", 256, "16 pro");

Console.WriteLine("=============================");
Console.WriteLine("Smartphone Nokia: ");
Console.WriteLine("=============================");
Console.WriteLine($"Número: {nokia.Number}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memory}GB");
Console.WriteLine($"Modelo: {nokia.Model}");
Console.WriteLine("=============================");
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");
Console.WriteLine("=============================\n");

Console.WriteLine("=============================");
Console.WriteLine("Smartphone IPhone: ");
Console.WriteLine("=============================");
Console.WriteLine($"Número: {iphone.Number}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memory}GB");
Console.WriteLine($"Modelo: {iphone.Model}");
Console.WriteLine("=============================");
nokia.ReceiveCall();
nokia.InstallApp("Telegram");
Console.WriteLine("=============================\n");