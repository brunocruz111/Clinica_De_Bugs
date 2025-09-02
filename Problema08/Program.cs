// See https://aka.ms/new-console-template for more information
int[] notas = new int[5];
for (int i = 0; i <= notas.Length; i++)
{
Console.Write($"Digite a nota {i + 1}: ");
notas[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < notas.Length; i++)
{
string situacao = notas[i] = 7 ? "Aprovado" : "Reprovado";
Console.WriteLine($"Nota {i + 1}: {notas[i]} - {situacao}");
}