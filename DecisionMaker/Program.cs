using System.Numerics;
using System.Reflection.Metadata.Ecma335;

bool rerun = true;
do //Extra Challenge
{
    Console.Write("Enter an integer between 1 and 100 inclusive: ");
    int integer = int.Parse(Console.ReadLine());

    if (integer <= 100 && integer >= 1) //Extra Challenge
    {
        if (integer % 2 != 0 && integer < 60) //% gives us the remainder so if it's divisible by 2 this means it's even, if not, it's odd
        {
            Console.WriteLine($"You have entered {integer}, this number is odd and less than 60.");
        }
        else if (integer % 2 == 0 && (integer >= 2 && integer <= 24))
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (integer % 2 == 0 && (integer >= 26 && integer <= 60))
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (integer % 2 == 0 && integer > 60)
        {
            Console.WriteLine($"You have entered {integer}, this number is even and greater than 60.");
        }
        else if (integer % 2 != 0 && integer > 60)
        {
            Console.WriteLine($"You have entered {integer}, this number is odd and greater than 60.");
        }
        Console.WriteLine("Run again? Enter yes or y to continue, or press enter to exit.");
        string answer = Console.ReadLine();

        //determine to loop depending on user's answer
        if (answer == "y" || answer == "yes")
        {
        }
        else
        {
            Console.WriteLine("Goodbye!");
            rerun = false;
        }
    }
    else
    {
        Console.WriteLine("You did not enter an integer between 1 and 100 inclusive. This includes 1 and 100.");
        Console.WriteLine("Run again? Enter yes or y to continue, or press enter to exit.");
        string answer = Console.ReadLine();

        //determine to loop depending on user's answer
        if (answer == "y" || answer == "yes")
        {
            rerun = true;
        }
        else
        {
            Console.WriteLine("Goodbye!");
            rerun = false;
        }
    }
}
while (rerun == true);