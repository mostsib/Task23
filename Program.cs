// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

void GetCubeNumber(int num)
{
    int count = 1;
    while (count <=Math.Abs(num))
    {
        Console.WriteLine($"-> {Math.Pow(count,3)}");
        count++;
    }
}
GetCubeNumber(number);