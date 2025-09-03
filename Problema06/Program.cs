// See https://aka.ms/new-console-template for more information

using System.Globalization;

double total = 0;
while (total < 50)
{
    Console.WriteLine("Digite o valor a ser guardado: ");
    //removido a troca de "," e ".".
    double valor = double.Parse(Console.ReadLine()!,  CultureInfo.InvariantCulture);
    //Inverter operador =+ por +=
    total += valor;
}
//Falta o $ na interpolacao das strings
Console.WriteLine($"Valor atingido! total economizado: R$ {total.ToString("0.00",CultureInfo.InvariantCulture)}");

 
