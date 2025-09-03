//Contem ERRO:
//int[][] matriz = new int[3, 3];
//Para criar uma matriz retangular fixa o certo seria:

int[,] matriz = new int[3, 3];

//Erro:
//int somaTotal = 0
//Faltou ; no final.
int somaTotal = 0;
int somaDiagonal = 0;
int[] maiores = new int[3];
//ERRO
//i <= 3 
//Uma matriz 3x3 vai de 0 a 2, então o i não pode ser = 3
for (int i = 0; i < 3; i++)
{   //ERRO
    //j <=3
    //Uma matriz 3x3 vai de 0 a 2, então o i não pode ser = 3
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Valor [{i},{j}]: ");
        int valor = int.Parse(Console.ReadLine());
        //ERRO:
        //matriz[j, i] = valor;
        //Os valores pegos da matriz estão invertidos
        matriz[i, j] = valor;
        somaTotal = somaTotal + valor;
        if (i == j)
        {
            //ERRO:
            //somaDiagonal += matriz[i, i + 1];
            //Para somar a diagonal de uma matriz quadrada o certo é
            //usar i e j, sendo que o teste de que os 2 são iguais
            //ja foi feito
            somaDiagonal += matriz[i, j];
        }
        if (valor > maiores[i])
        {
            maiores[i] = valor;
        }
    }
}
//ERRO:
//Console.WriteLine("Soma total: {somaTotal}");
//Faltou $ antes das aspas
Console.WriteLine($"Soma total: {somaTotal}");
//Console.WriteLine("Soma diagonal principal: " + somaDiagonal);
//Preferivel usar interpolação
Console.WriteLine($"Soma diagonal principal: {somaDiagonal}");
//ERRO:
//Console.WriteLine("Maiores por linha:");
//Faltou interpolar os maiores
Console.WriteLine($"Maiores por linha: {maiores[0]}, {maiores[1]}, {maiores[2]}");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(maiores[i]);
}
//Erro
//int[,] transposta = new int[3][3];
//Na matriz retangular o certo seria
int[,] transposta = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        //ERRO:
        //transposta[i, j] = matriz[i, j];
        //Para transpor tem que inverter o i pelo j
        transposta[j,i] = matriz[i, j];
    }
}
Console.WriteLine("Matriz transposta:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {

        Console.Write(transposta[i, j] + " ");
    }
    //ERRO
    //Console.WriteLine()
    //Faltava o ;
    Console.WriteLine();
}

