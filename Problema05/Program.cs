// See https://aka.ms/new-console-template for more information
string resposta;
do
{
Console.Write("Deseja sair? (S/N): ");
resposta = Console.ReadLine().ToUpper()[0];
}
while (resposta != "S" || resposta != "N");
Console.writeline("Programa encerrado.");