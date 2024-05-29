using System.Net;
using DesafioPOO.Models;


Console.Clear();

Smartphone iphone = new Iphone(numero: "(99) 99999-9999", modelo: "X", imei:"ABC", memoria: 1);
Console.WriteLine(iphone.ToString());
Console.WriteLine("Trocando numero:");
iphone.Numero = "(47) 12345-6789";
Console.WriteLine(iphone.ToString());
iphone.Ligar();


Smartphone nokia = new Nokia(numero: "(99) 4002-8922", modelo: "NX0", imei:"@@@", memoria: 140);
Console.WriteLine(nokia.ToString());
nokia.ReceberLigacao();