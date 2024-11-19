using System; 
class Program 
{ 
 static void Main() 
 { 
 Console.Write("Masukkan nilai jajargenjang: "); 
 double alas = Convert.ToDouble(Console.ReadLine()); 
 Console.Write("Masukkan nilai tinggi jajargenjang: "); 
 double tinggi = Convert.ToDouble(Console.ReadLine()); 
 double luas = 0.5 * alas * tinggi;  
 Console.WriteLine("Luas jajargenjang adalah: " + luas); 
 } 
} 
