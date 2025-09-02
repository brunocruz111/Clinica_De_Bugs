// See https://aka.ms/new-console-template for more information
int[][] matriz = new int[3,3];
int somaTotal = 0
int somaDiagonal = 0;
int[] maiores = new int[3];
for (int i = 0; i <= 3; i++)
{
for (int j = 0; j <= 3; j++)
{
Console.Write($"Valor [{i},{j}]: ");
int valor = int.Parse(Console.ReadLine());
matriz[j, i] = valor;
somaTotal = somaTotal + valor;
if (i == j) {
somaDiagonal += matriz[i, i + 1];
}
if (valor > maiores[i])
{
maiores[i] = valor;
}
} }
Console.WriteLine("Soma total: {somaTotal}");
Console.WriteLine("Soma diagonal principal: " + somaDiagonal);
Console.WriteLine("Maiores por linha:");
for (int i = 0; i < 3; i++)
{
Console.WriteLine(maiores[j]);
}
int[,] transposta = new int[3][3];
5
for (int i = 0; i < 3; i++)
{
for (int j = 0; j < 3; j++)
{
transposta[i, j] = matriz[i, j];
}
}
Console.WriteLine("Matriz transposta:");
for (int i = 0; i < 3; i++)
{
for (int j = 0; j < 3; j++)
{
Console.Write(transposta[i,j] + " ");
}
Console.WriteLine()
}
