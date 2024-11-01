using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep3 World!");
//     }
// }
Random randomGenerator = new Random();
int magic_number = randomGenerator.Next(1, 101);

int guess = -1;

while (guess != magic_number)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());
    
    if (magic_number > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (magic_number < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("Good job! You guessed it!");
    }
} 


