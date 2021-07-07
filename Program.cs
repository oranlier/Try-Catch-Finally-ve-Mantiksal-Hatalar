using System;

namespace Try_Catch_Finally_ve_Mantiksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Bir sayı gir:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                //bir kod blogu hata alsın ya da almasın çalıştırılmasını istediğiniz baska bir 
                //kod blogu varsa bu finally e yazılır,
                //zorunlu değil finally kısımı
                Console.WriteLine("İşlem Tamamlandı.");
            }

            try
            {
                //int a =int.Parse(null);
                //int t =int.Parse("test");
                int t2 =int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok kucuk ya da cok buyuk bır deger gırdınız");
                Console.WriteLine(ex);
            }
        }
    }
}
