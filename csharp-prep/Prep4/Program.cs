using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep4 World!");
//     }
// }

List<int> numbers = new List<int>();

    int user_number = -1;
    while (user_number != 0)
    {
        Console.Write("Enter a number (Press 0 to quit): ");
            
        string userResponse = Console.ReadLine();
        user_number = int.Parse(userResponse);

        if (user_number != 0)
        {
            numbers.Add(user_number);
        }
    }

    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    Console.WriteLine($"The sum is: {sum}");

    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

    Console.WriteLine($"The max is: {max}");