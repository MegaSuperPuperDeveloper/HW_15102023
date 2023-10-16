// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ack(int n, int m) {
    while(m != 0) {
        if(n == 0) n = 1;
        else n = ack(n - 1, m);
        m = m - 1;
    }
    return n + 1;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m < 1 || n < 1) {
    Console.WriteLine("Ошибка ввода!");
    return;
}
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {ack(n, m)}");
