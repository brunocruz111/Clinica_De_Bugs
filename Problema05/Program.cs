// See https://aka.ms/new-console-template for more information
string? resposta;

do
{
    //Comando Write incompleto
    Console.WriteLine("Deseja sair? (S/N): ");
    //Comando toupper escrito de maneira incorreta
    resposta = Console.ReadLine().ToUpper();
    Console.WriteLine(resposta);
}
//Condição comparador de string não pode ser escrito da maneira escrito, é necessário utilizar o comando equals que compara strings
while (!string.Equals(resposta,"S"));
//Comando escrito de forma incorreta
    Console.WriteLine("Programa encerrado.");
    