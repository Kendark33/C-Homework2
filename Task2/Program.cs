/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


void AnyThing()
{
    int newNumber = (new Random()).Next(1, 10000);
    Console.WriteLine($"Base number: {newNumber}");
    string numericAsString = newNumber.ToString();
        if (newNumber > 99)
    {
        int result = int.Parse(numericAsString[2].ToString());
        Console.WriteLine($" Третье цифра заданного числа: {result}");
        return;
    }
    else
        Console.WriteLine($"Третьей цифры числа нет");
}
AnyThing();