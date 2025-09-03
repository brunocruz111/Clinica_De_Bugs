Console.Write("Digite um número para ver a tabuada: ");
int num = int.Parse(Console.ReadLine());
//substitui o i-- por i++
for (int i = 1; i <= 10; i++)
{
    //substitui o j por i
    Console.WriteLine($"{num} x {i} = {num * i}");
}
