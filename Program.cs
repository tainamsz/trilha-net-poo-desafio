using DesafioPOO.Models;

Iphone iphone = new Iphone("(48)552456789","Iphone 15","23443759603945",128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
Console.WriteLine("");

Nokia nokia =new Nokia("(21)57854204","Nokia 2002","2334567830495823",256);
nokia.Ligar();
nokia.InstalarAplicativo("Snapchat");
nokia.ReceberLigacao();