// // See https://aka.ms/new-console-template for more information

Console.WriteLine("Let's play Rock Paper Scissors, ok?");

string firstSign = GetCorrectSign("Player 1");
string secondSign = GetCorrectSign("Player 2");

if (firstSign.Equals(secondSign, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("It's a tie!");
}
else if ((firstSign == "rock" && secondSign == "scissors")
    || (firstSign == "paper" && secondSign == "rock")
    || (firstSign == "scissors" && secondSign == "paper"))
{
    Console.WriteLine("First player won!");
}
else
{
    Console.WriteLine("Second player won!");
}

string GetCorrectSign(string playerName)
{
    Console.WriteLine($"{playerName}, provide sign (rock/paper/scissors)");
    string sign = Console.ReadLine()!;
    // czy podany znak NIE jest jednym z oczekiwanych?
    while (!(sign == "rock" || sign == "paper" || sign == "scissors"))
    {
        // wyświetl ze znak jest niepoprawny
        Console.WriteLine("Provide correct sign! (rock/paper/scissors)");
        // pozwól poprawić swoje zachowanie (poda ponownie znak)
        sign = Console.ReadLine()!;
    }

    return sign;
}