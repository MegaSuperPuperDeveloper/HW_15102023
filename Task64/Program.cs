// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить 
// с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void CountNtoZero(int n) { // Функция перечисляет числа от N до 1 используя Рекурсию.
    if(n != 1) Console.Write($"{n}, ");
    else {
        Console.Write($"{n}" + '"');
        return;
    }
    CountNtoZero(n - 1);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 1) {
    Console.WriteLine("Ошибка ввода!");
    return;
}
Console.Write($"N = {N} -> " + '"');
CountNtoZero(N);