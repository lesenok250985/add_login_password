﻿//zadanie 3 ANONIMUS

string pass = "";
Console.Write("Enter your login: ");
ConsoleKeyInfo key;

do
{
    key = Console.ReadKey(true);

    // Backspace Should Not Work
    if (key.Key != ConsoleKey.Backspace)
    {
        pass += key.KeyChar;
        Console.Write("*");
    }
    else
    {
        Console.Write("\b");
    }
}
// Stops Receving Keys Once Enter is Pressed
while (key.Key != ConsoleKey.Enter);

Console.WriteLine();
Console.WriteLine("Hello anonimus");
