

Console.WriteLine("Let's play Rock Paper Scissors!");

Console.WriteLine("Player 1, provide sign (rock/paper/scissors)");
string firstSign = Console.ReadLine()!;

while (!(firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
{
   
    Console.WriteLine("Provide correct sign! (rock/paper/scissors)");
 
    firstSign = Console.ReadLine()!;
}

    Console.WriteLine("Player 2, provide sign (rock/paper/scissors)");
string secondSign = Console.ReadLine()!;

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





