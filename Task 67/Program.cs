// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int userInput = UserInput("Введите целое число: ", "Ошибка ввода!");


int result = Numbers(userInput);

Console.WriteLine(result);

int Numbers( int n)
{
    if (n == 0) 
        return 0;
    return n % 10 + Numbers(n/10);
}


int UserInput (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}
