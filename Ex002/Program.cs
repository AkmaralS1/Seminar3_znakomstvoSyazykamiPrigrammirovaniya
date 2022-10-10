// Задача 18. Напишите программу которая по заданному номеру четверти
// показывает диапазон возможных координат в этой четверти (х и у).

Console.Clear();
Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (n == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (n == 3)
    Console.WriteLine("x < 0 and y < 0");
else 
    Console.WriteLine("x > 0 and y < 0");