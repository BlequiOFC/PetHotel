


Console.Clear();

String Especie, Raça, Nome, Idade, Cor;

Console.WriteLine("CHECK-IN PET HOTEL");
Console.WriteLine();

Console.WriteLine("Escreva a Espécie do seu animal:");
Especie = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine("Escreva a raça do seu animal:");
Raça = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine("Escreva a Alcunha (Nome) do seu animal:");
Nome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine("Digite a idade do seu animal:");
Idade = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine("Escreva a Cor/Raça do seu animal:");
Cor = Console.ReadLine()!;
Console.WriteLine();


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;

// TITULO DO PET HOTEL

Console.WriteLine("+=========================================================+");

Console.Write("|                 ");

Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.WriteLine("+=========================================================+");


// PRIMEIRA LINHA DE INFORMAÇÕES, ESPÉCIE E RAÇA


Console.Write($"| Espécie: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));

Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write(" | Raça: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Raça.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22)); 

Console.ForegroundColor = ConsoleColor.DarkGray;

Console.WriteLine(" |");



// SEGUNDA LINHA DE INFORMAÇÕES, NOME, IDADE E COR


Console.WriteLine("+=========================================================+");

Console.Write("| Atende pela alcunha de: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Nome.Trim().ToUpper().PadLeft(32, '.').Substring(0, 32));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("|");


Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write(" ano(s) | Pelagem/cor: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(Cor.Trim().ToUpper().PadLeft(24, '.').Substring(0, 24));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.WriteLine("|");


Console.WriteLine("+=========================================================+");


Console.ResetColor();








