/**
int[][] matriz = new int[3, 3];
//Faltou o ; para finalizar linha de comando
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
//Faltou o simbolo de $ antes de abrir aspas para interpolar
Console.WriteLine("Soma total: {somaTotal}");
//O ideal é usar interpolação, e não concatenação
Console.WriteLine("Soma diagonal principal: " + somaDiagonal);
Console.WriteLine("Maiores por linha:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(maiores[j]);
}
//Não pode ter nada dentro do colchete
int[,] transposta = new int[3][3];
//Valor solto causando erro de compilação
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
//O ideal é usar interpolação, e não concatenação
Console.Write(transposta[i,j] + " ");
}
//Codigo não finalizado
Console.WriteLine()
}
*//

int[][] matriz = new int[3, 3];

int somaTotal = 0;
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
int[] transposta = new int[3][3];
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

