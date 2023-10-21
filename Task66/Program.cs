// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке
//  от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMtoN(int M, int N, int sum = 0) { // Функция считает сумму от M до N используя Рекурсию.
    sum += M;
    if(M == N) return sum;
    return SumMtoN(M + 1, N, sum);
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if(M < 1 || N < 1 || M > N) {
    Console.WriteLine("Ошибка ввода!");
    return;
}
Console.Write($"M = {M}; N = {N} -> {SumMtoN(M, N)}");
