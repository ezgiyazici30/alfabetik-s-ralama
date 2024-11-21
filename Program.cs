// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        ArrayList isimler = new ArrayList();
        isimler.Add("Zeynep");
        isimler.Add("Ahmet");
        isimler.Add("Mehmet");
        isimler.Add("Ayşe");
        isimler.Add("Elif");

       
        isimler.Sort();

        
        Console.WriteLine("Alfabetik sıralama:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}

