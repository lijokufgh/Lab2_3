﻿Console.WriteLine("Введите длинну массива");
int dlin = int.Parse(Console.ReadLine());
int[] mas = new int[dlin];

void Menu()
{
    Console.WriteLine($"Массив");
    for (int i = 0; i < dlin; i++)
    {
        mas[i] = i;
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine($"\nНамира объектов");
for (int i = 0; i < dlin; i++)
    {
        Console.Write($"[{mas[i]}] ");
    }
    Console.WriteLine($"\nВпереди стоящие");
for (int i = 1; i < dlin; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine($"\nПозади стоящие");
for (int i = 0; i < dlin - 1; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine("\n1) Связь одни к однаму.\n2) Множественная связь.\n3) Результат.");
int q = int.Parse(Console.ReadLine());
switch (q)
{
    case 1:
        Odin();
        break;
    case 2:
        Mnogo();
        break;
    case 3:
        Res(dlin);
        break;
    default:
        Menu();
        break;
}
}
Menu();
void Close()
{
    Console.ReadKey();
    Console.Clear();
    Menu();
}
void Odin()
{
    for (int i = 0; i < dlin - 1; i++)
    {
        Console.WriteLine($"Объект: {i} стоит перед {i + 1}");
    }
    Close();
}

void Mnogo()
{
    Console.WriteLine($"После {mas[0]} стоит {mas[1]}");
    for (int i = 1; i < dlin - 2; i++)
    {
        Console.WriteLine($"Перед {i} стоит {i - 1} после {i + 1}");
    }
    Console.WriteLine($"Перед {dlin - 1} стоит {dlin - 2}");
    Close();
}
void Res(int dlin)
{
    Console.Clear();


    Console.WriteLine($"Связанные обюъекты.");

    for (int i = dlin - 1; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine($"Не вязанные обюъекты.");

    for (int i = 0; i < dlin; i++)

    {

        Console.WriteLine(i);
    }
    Console.WriteLine($"Объекты со множеством связий");
    for (int i = 0; i < dlin; i++) Console.WriteLine(i);
}