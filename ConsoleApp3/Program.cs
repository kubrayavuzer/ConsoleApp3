using System;

class Program
{

    static void Main()

    {
        // Kullanıcıdan bir sayı girişi alınması

        Console.WriteLine("Bir sayı giriniz.");
        int sayı = Convert.ToInt32(Console.ReadLine());

        // Sayının 10'a eşit, küçük veya büyük olma durumlarına göre bilgilendirme mesajı
        if (sayı == 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");

        }

        else if (sayı < 10)
        {
            Console.WriteLine("Girdiğiniz 10'dan küçüktür.");
        }

        else

        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");

        }

        // Sayının tek mi çift mi olduğunu yazdırılması

        if (sayı % 2 == 0)
        {
            Console.WriteLine("Sayı çift sayıdır.");
        }

        else
        {
            Console.WriteLine("Sayı tek sayıdır.");
        }
    }

}













