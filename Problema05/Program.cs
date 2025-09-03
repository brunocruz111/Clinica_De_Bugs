﻿// See https://aka.ms/new-console-template for more information
string? resposta;

do
{
    //Comando Write incompleto
    Console.WriteLine("Deseja sair? (S/N): ");
    //Comando toupper escrito de maneira incorreta
    resposta = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
}
//Condição errada comparador de string não pode ser escrito da maneira como estava escrita, podesse utilizar o comando equals que compara strings
while (!string.Equals(resposta,"S"));
//Comando escrito de forma incorreta 
    Console.WriteLine("Programa encerrado.");
    
