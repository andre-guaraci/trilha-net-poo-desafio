using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("12312321312", "Nokia N40", "1234565", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine(nokia.Numero);

Console.WriteLine("--------------------------\n");


Console.WriteLine("Smartphone Nokia");
Iphone iphone = new Iphone("3333221123", "Iphone 16 Pro Max", "1232133123", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine(iphone.Numero);
