Console.Clear();


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("O objeto está se movendo (Sim/Não)? ");
bool Movendo = Console.ReadLine()!.Trim().Substring(0,1) == "S";
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Deveria...........................? ");
bool Deveria = Console.ReadLine()!.Trim().Substring(0,1) == "S";
Console.ResetColor();



if(!Movendo && !Deveria)
{
    Console.WriteLine("\nÓtimo");
}

else if (!Movendo && Deveria)
{
    Console.WriteLine("\nUse WD-40");
}

else if (Movendo && Deveria)
{
    Console.WriteLine("\nÓtimo");
}

else
{
    Console.WriteLine("\nUse Silver Tape");
}