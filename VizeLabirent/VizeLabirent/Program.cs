using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent
{
    internal class Program
    {
        //integerlar konumun hangi özelliğe sahip olduğunu belirtir
        // Program.konum 0 ise hiç geçilmemiş yol, 1 ise duvar, 2 ise geçilmiş yol,
        // 3 ise geri dönülmüş ve bir daha gidilmeyecek yol, 4 ise bomba
        public static int[,] konum = new int[30, 30];
        public static char tercih;                   
                                                     
        static void Main(string[] args)
        {
            Console.WriteLine("Labirent yolu bulma programına hoş geldiniz :)");
            Labirent.Oluştur(); Console.WriteLine("Yeni labirent oluşturuldu");//Labirent oluşturma satırı
            //Labirent.BombaYerlestirici(); //Diziye koddan sayılar tanımlanırsa bu satırı yorumdan çıkarabilirsiniz
            Console.WriteLine("Bu program biraz buglu, W harfini yazdığınız halde çalışmazsa kapatıp tekrar açınız.");
            Console.WriteLine("Yol bulma algoritmasını çalıştırmak için W yi tuşlayınız: ");
            tercih = Convert.ToChar(Console.ReadLine());
            if (tercih == 'w' || tercih == 'W')//Bu kısım buglu, kapatıp tekrar çalıştırın, çalışmazsa exe'leri silin veya IDE'yi kapatıp tekrar açın
            { Gezgin.YolBulucu(); }
            Console.WriteLine("Yolun kordinatlarını yazdırmak için K tuşuna");
            Console.WriteLine("Çıkış yolunu göstermesi için X tuşuna,");
            Console.WriteLine("Bombaları göstermesi için B tuşuna,");
            Console.WriteLine("Labirent'in orijinal halini göstermesi için L tuşuna basınız.");
            tercih = Convert.ToChar(Console.ReadLine());
            if (tercih == 'x' || tercih == 'X')
                Goster.Yol();
            else if (tercih == 'b' || tercih == 'B')
                Goster.Bomba();
            else if (tercih == 'l' || tercih == 'L')
                Goster.Labirent();
            else if (tercih == 'k' || tercih == 'K')
                Goster.Kordinatlar();

            Console.ReadLine();
        }
    }
}
