using System;
class Program
{
    static void Main()
{
Console.Write("angka pertama:");
int angka1 = Convert.ToInt32(Console.ReadLine());
Console.Write("angka kedua:");
int angka2 = Convert.ToInt32(Console.ReadLine());
int hasil = angka1+angka2;
Console.WriteLine("hasil penjumlahan:" + hasil);
}
}