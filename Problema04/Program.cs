// See https://aka.ms/new-console-template for more information


// comando da linha 5 estava faltando Line, também faltava especificar para que os números servem
Console.WriteLine("Digite um número de 1 a 7 correspondentes ao dias da semana : ");
// variavel declarada com o tipo errado, console faltando partes
int? dia = int.Parse(Console.ReadLine());
// variavel declarada errada estava diaa
switch (dia)
{
    case 1:    //Faltava ponto e vírgula
        Console.WriteLine("Domingo");
            break;
//case estava entre "2", e faltam os breaks
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    //faltava casos
    case 4:
        Console.WriteLine("Quarta-Feira");
        break;

    case 5:
        Console.WriteLine("Quinta-Feira");
        break;

    case 6:
        Console.WriteLine("Sexta-Feira");
        break;

    case 7:
        Console.WriteLine("Sabado");
        break;

    default:
        Console.WriteLine("Número inválido");
        break;
} 
