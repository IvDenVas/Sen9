// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
int n = UserInput("Введите число A: ", "Ошибка ввода!");
int m = UserInput("Введите число B: ", "Ошибка ввода!");

int result = Pow(n, m);

Console.WriteLine(result);

int Pow( int n, int m)
{
    if (m == 0) 
        return 1;
    return n * Pow(n,m -1 );
}



int UserInput (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        if (num >= 0)
            return num;
        Console.WriteLine(errorMessage);
    }
}