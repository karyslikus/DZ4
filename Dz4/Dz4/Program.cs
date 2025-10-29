Random random = new Random();
string playAgain;

do
{
    int secretNumber = random.Next(1, 101);
    int b = 0;
    int c = 0;
    int maxAttempts = 7;
    bool guessed = false;

    Console.WriteLine("загадано число от 1 до 100 ");
    
    while (c < maxAttempts && !guessed)
    {
        Console.WriteLine("число");
        b = Convert.ToInt32(Console.ReadLine());
        c++;
        
        if (b < secretNumber)
        {
            Console.WriteLine("загаданное число больше");
        }
        else if (b > secretNumber)
        {
            Console.WriteLine("загаданное число меньше");
        }
        else
        {
            guessed = true;
            Console.WriteLine("вы угадали "+ secretNumber + " за "+ c +" попыток");
        }
    }

    if (!guessed)
    {
        Console.WriteLine("вы проиграли. загаданное число было " + secretNumber);
    }

    Console.WriteLine("сыграть еще раз? (да/yes)");
    playAgain = Console.ReadLine().ToLower();
    
} while (playAgain == "да" || playAgain == "yes");

Console.ReadLine();