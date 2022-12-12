// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
int m = UserInput("Введите целое число M: ", "Ошибка ввода!");
int n = UserInputTwo("Введите целое число N: ", "Ошибка ввода!");
int start = m;

string result = Numbers(start, n);

Console.WriteLine(result);

string Numbers(int start, int n)
{
    if (start == n) 
        return start.ToString();
    // if (start == m)
    //     return start.ToString();
    return start + " " + Numbers(start + 1, n);
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

int UserInputTwo (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num > m)
            return num;
        Console.WriteLine(errorMessage);
    }
}