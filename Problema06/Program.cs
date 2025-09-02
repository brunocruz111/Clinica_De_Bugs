// See https://aka.ms/new-console-template for more information
double total = "0";
while (total < 50)
{
Console.Write("Digite o valor a ser guardado: ");
double valor = double.Parse(Console.ReadLine().Replace('.', ','));
total =+ valor;
}
Console.WriteLine("Meta atingida! Total economizado: R$ {total}");
