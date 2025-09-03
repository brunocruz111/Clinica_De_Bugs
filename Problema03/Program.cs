// See https://aka.ms/new-console-template for more information

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

//Operador logico escrito de forma incorreta e sem ponto e virgula na condicional if
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}