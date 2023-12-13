// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N. Использовать рекурсию, не использовать циклы. */

/* internal class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine();

        PrintValue(M, N, M);
        Console.ReadLine();
    }

    static void PrintValue(int M, int N, int value)
    {
        if (value > N)
            return;
        Console.WriteLine(value);
        value++;
        PrintValue(M, N, value);
    }
}
*/

/* Задача 2: Напишите программу 
вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/
/* internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(A(n, m));
        Console.ReadLine();
    }

    static int A(int n, int m)
    {
        if (n == 0) return m + 1;
        if (n != 0 && m == 0) return A(n - 1, 1);
        if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
        return A(n, m);
    }
}
*/

/* Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/

static int[] v = { 1, 2, 3, 4, 5 };
static int g = v.Length - 1;


static void Main(string[] args)
{
    recursion(g);
    Console.ReadKey();
}
static void recursion(int x)
{
    int n = 0;
    int[] shiftx = new int[5];
    if (x >= 0)
    {
        shiftx[n] = v[x];
        Console.WriteLine(shiftx[n]);
        n++;
        x--;
    }
    else
    {
        return;
    }
    recursion(x);
}
static int[] v = { 1, 2, 3, 4, 5 };
static int g = v.Length - 1;


static void Main(string[] args)
{
    recursion(g);
    Console.ReadKey();
}
static void recursion(int x)
{
    int n = 0;
    int[] shiftx = new int[5];
    if (x >= 0)
    {
        shiftx[n] = v[x];
        Console.WriteLine(shiftx[n]);
        n++;
        x--;
    }
    else
    {
        return;
    }
    recursion(x);
}

