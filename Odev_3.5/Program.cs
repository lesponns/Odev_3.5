using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir banka müşteri hesaplarını yöneten bir program geliştirmek istemektedir. 
            Müşteriler, hesaplarına para yatırabilir veya çekebilirler. 
            Müşteri işlemleri tamamladığında hesap bakiyeleri güncellenir ve
            müşteriye yeni bakiye gösterilir. İşlem sırasında, müşteri işlemlere devam
            etmek isteyip istemediğini belirtmelidir.
            */

            int input = 1, balance = 1000;

            while (input > 0)
            {
                Console.Clear();//Konsolu temizle.
                Console.Write("1-Para Yatırma İşlemi \n2-Para Çekme İşlemi " +
                "\nÇıkmak için 0 giriniz.\n\nYapılacak işlem: ");//Yapılabilecek işlemleri listele.
                input = int.Parse(Console.ReadLine());//Girilen değeri değişkene ata.
                if (input != 0)//Çıkış için 0 değerini kontrol et.
                { 
                    switch (input) //Switch case başlat
                    {
                        case 1://1 para yatırma işlemi 
                            Console.Clear();//Konsolu temizle.
                            Console.Write("Yatırılacak miktar: ");
                            input=int.Parse(Console.ReadLine());//Girilen değeri değişkene ata
                            balance = balance + input;
                            Console.Write("Hesap bakiyeniz: " + balance);
                            Console.ReadKey();//Bir tuşa basılana kadar bekle
                            break;
                        case 2:
                            Console.Clear();//Konsolu temizle.
                            Console.Write("Çekilecek miktar: ");
                            input = int.Parse(Console.ReadLine());//Girilen değeri değişkene ata
                            balance = balance - input;//Bakiyeden çekilen miktar kadar eksiltme
                            Console.Write("Hesap bakiyeniz: " + balance);//İşlem sonu bakiye görüntüleme
                            Console.ReadKey();//Bir tuşa basılana kadar bekle
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("See you soon.\nPress any button for exit.");
                    Console.ReadKey();
                }
            }
        }
    }
}
