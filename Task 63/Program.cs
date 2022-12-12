// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
int userInput = UserInput("Введите целое число N: ", "Ошибка ввода!");
int start = 1;
string result = NaturalNumbers(start, userInput);


Console.WriteLine(result);
string NaturalNumbers(int start, int n)
{
    if (start == n) 
        return start.ToString();
    return start + " " + NaturalNumbers(start + 1, n);
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