using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukan jumlah baris: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.Write(new string('#', i));
            Console.Write(" ");
            Console.WriteLine(new string('#', i));
        }
    }
}