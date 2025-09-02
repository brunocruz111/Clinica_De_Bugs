// See https://aka.ms/new-console-template for more information
int[,] matriz = new int[3];
for (int i = 0; i <= 3; i++)
{
for (int j = 0; j <= 3; j++)
{
Console.Write($"Valor [{i},{j}]: ");
matriz[i, j] = int.Parse(Console.ReadLine());
}
}
Console.Write("Número a buscar: ");
int buscado = int.Parse(Console.ReadLine())
bool encontrado = null;
int linha = 0, coluna = 0;
for (int i = 0; i <= 3; i++)
6
{
for (int j = 0; j <= 3; j++)
{
if (matriz[i, j] = buscado)
{
encontrado == true;
linha = j;
coluna = i;
break;
} }
if (encontrado) break;
}
if (encontrado = true)
{
Console.writeline($"Encontrado em ({linha + 1}, {coluna + 1})")
}
else
{
Console.WriteLine("Número não encontrado: {buscado}");
}
