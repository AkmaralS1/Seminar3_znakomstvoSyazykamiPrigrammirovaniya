//Задача17. Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.Write("введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у: ");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0) // проверка: пока "х" равно "0" то
{    
    Console.Write("введите координату х: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0) // проверка: пока "y" равно "0" то
{    
    Console.Write("введите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}

if (x > 0 && y > 0) //Если 'х' больше нуля (&&)И 'у' больше нуля
    Console.WriteLine("I");
else if (x < 0 && y > 0) 
    Console.WriteLine("II");
else if (x < 0 && y < 0) 
    Console.WriteLine("III");
else 
    Console.Write("IV");
