/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7");
string dayOfTheWeek = Console.ReadLine();

if (dayOfTheWeek == "1")
    Console.WriteLine("Понедельник");

else if (dayOfTheWeek == "2")
    Console.WriteLine("Вторник");

else if (dayOfTheWeek == "3")
    Console.WriteLine("Среда");

else if (dayOfTheWeek == "4")
    Console.WriteLine("Четверг");

else if (dayOfTheWeek == "5")
    Console.WriteLine("Пятница");

else if (dayOfTheWeek == "6")
    Console.WriteLine("Суббота является выходным днем");

else if (dayOfTheWeek == "7")
    Console.WriteLine("Воскресенье является выходным днем");
else
    Console.WriteLine("Введено не верное значение, требуется указать число от 1 до 7");
