using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent
{
    internal class Goster
    {
        // Program.konum 0 ise hiç geçilmemiş yol, 1 ise duvar, 2 ise geçilmiş yol,
        // 3 ise geri dönülmüş ve bir daha gidilmeyecek yol, 4 ise bomba
        public static void Labirent()
        {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (Program.konum[j, i] == 1)
                        Console.Write("= ");
                    else if (Program.konum[j, i] == 0 || Program.konum[j, i] == 2 || Program.konum[j, i] == 3 || Program.konum[j, i] == 4)
                        Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Yolun kordinatlarını yazdırmak için K tuşuna");
            Console.WriteLine("Çıkış yolunu göstermesi için X tuşuna,");
            Console.WriteLine("Bombaları göstermesi için B tuşuna,");
            Console.WriteLine("Labirent'in orijinal halini göstermesi için L tuşuna basınız.");
            Program.tercih = Convert.ToChar(Console.ReadLine());
            if (Program.tercih == 'x' || Program.tercih == 'X')
                Goster.Yol();
            else if (Program.tercih == 'b' || Program.tercih == 'B')
                Goster.Bomba();
            else if (Program.tercih == 'l' || Program.tercih == 'L')
                Goster.Labirent();
            else if (Program.tercih == 'k' || Program.tercih == 'K')
                Goster.Kordinatlar();
        }
        public static void Yol() {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (Program.konum[j, i] == 1)
                        Console.Write("= ");
                    else if (Program.konum[j, i] == 2)
                        Console.Write("X ");
                    else if (Program.konum[j, i] == 0 || Program.konum[j, i] == 3 || Program.konum[j, i] == 4)
                        Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Yolun kordinatlarını yazdırmak için K tuşuna");
            Console.WriteLine("Çıkış yolunu göstermesi için X tuşuna,");
            Console.WriteLine("Bombaları göstermesi için B tuşuna,");
            Console.WriteLine("Labirent'in orijinal halini göstermesi için L tuşuna basınız.");
            Program.tercih = Convert.ToChar(Console.ReadLine());
            if (Program.tercih == 'x' || Program.tercih == 'X')
                Goster.Yol();
            else if (Program.tercih == 'b' || Program.tercih == 'B')
                Goster.Bomba();
            else if (Program.tercih == 'l' || Program.tercih == 'L')
                Goster.Labirent();
            else if (Program.tercih == 'k' || Program.tercih == 'K')
                Goster.Kordinatlar();
        }
        public static void Bomba() {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (Program.konum[j, i] == 1)
                        Console.Write("= ");
                    else if (Program.konum[j, i] == 4)
                        Console.Write("B ");
                    else if (Program.konum[j, i] == 0 || Program.konum[j, i] == 2 || Program.konum[j, i] == 3)
                        Console.Write("  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Yolun kordinatlarını yazdırmak için K tuşuna");
            Console.WriteLine("Çıkış yolunu göstermesi için X tuşuna,");
            Console.WriteLine("Bombaları göstermesi için B tuşuna,");
            Console.WriteLine("Labirent'in orijinal halini göstermesi için L tuşuna basınız.");
            Program.tercih = Convert.ToChar(Console.ReadLine());
            if (Program.tercih == 'x' || Program.tercih == 'X')
                Goster.Yol();
            else if (Program.tercih == 'b' || Program.tercih == 'B')
                Goster.Bomba();
            else if (Program.tercih == 'l' || Program.tercih == 'L')
                Goster.Labirent();
            else if (Program.tercih == 'k' || Program.tercih == 'K')
                Goster.Kordinatlar();
        }
        public static void Kordinatlar()
        {
            for (int i = 0; i < 30; i++)
            {
                for(int j=0;j<30; j++)
                {
                    if (Program.konum[j, i] == 2) {
                        int x = j + 1, y = i + 1;
                        Console.Write("({0},{1}) ",x,y); }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Yolun kordinatlarını yazdırmak için K tuşuna");
            Console.WriteLine("Çıkış yolunu göstermesi için X tuşuna,");
            Console.WriteLine("Bombaları göstermesi için B tuşuna,");
            Console.WriteLine("Labirent'in orijinal halini göstermesi için L tuşuna basınız.");
            Program.tercih = Convert.ToChar(Console.ReadLine());
            if (Program.tercih == 'x' || Program.tercih == 'X')
                Goster.Yol();
            else if (Program.tercih == 'b' || Program.tercih == 'B')
                Goster.Bomba();
            else if (Program.tercih == 'l' || Program.tercih == 'L')
                Goster.Labirent();
            else if (Program.tercih == 'k' || Program.tercih == 'K')
                Goster.Kordinatlar();
        }
    }
}