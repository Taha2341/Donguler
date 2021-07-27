using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirme Kampı","Programlamaya Başlangıç İçin temel Kurs",
                "java","python","C#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }
            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
