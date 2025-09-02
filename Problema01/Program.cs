// See https://aka.ms/new-console-template for more information

//Falta ponto e virgula no final do Writeline
Console.WriteLine("Por favor, digite seu primeiro nome:");

//possivel variavel NULL ajuste com a declaracao da variavel com um ? na frente
string? primeiroNome = Console.ReadLine();

Console.WriteLine("Agora, digite sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Por fim, digite sua altura em metros (ex: 1,80):");
float altura = float.Parse(Console.ReadLine());

//WriteLine e Variavel primeiro nome escrita de maneira incorreta
Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura}m.");