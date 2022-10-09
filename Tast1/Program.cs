/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

void Task()
{
    Console.WriteLine("Введите трехзначное число");
    string newNumber= Console.ReadLine();
    string numericAsString = newNumber.ToString();
    int result = int.Parse (numericAsString[1].ToString());
    Console.WriteLine($"SecondNumeric: {result}");
}
Task();