// See https://aka.ms/new-console-template for more information

int[] notas = new int[5];
//Indice em c# comeca em 0 entao e necessario acessar ate Length-1.
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Digite a nota {i + 1}: ");
    notas[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < notas.Length; i++)
{
    //Comparacao estava sendo feita com = e nao com ==
    string situacao = notas[i] == 7 ? "Aprovado" : "Reprovado";
    Console.WriteLine($"Nota {i + 1}: {notas[i]} - {situacao}");
}