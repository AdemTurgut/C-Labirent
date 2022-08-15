using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent
{
    internal class Gezgin
    {
        public static void YolBulucu()
        {
            int yön = 2, x = 0, y = 0, StartY = 0, durum = 0;
            //mevcut konumlar
            //durum 0 ise devam ediyor, 1 ise bitişe geldi,
            ////2 ise çıkmazda, 3 ise bomba patladı
            Random random = new Random();
            while (durum != 1 && durum != 3 && StartY < 30)
            {
                if (Program.konum[0, StartY] == 0)
                {
                    y = StartY;
                    x = 0;
                    while (durum == 0)
                    {
                        // 1 yukarı, 2 sağ, 3 aşağı, 4 solu işaret eder. sıralama saat yönüne göredir.
                        // Program.konum 0 ise hiç geçilmemiş yol, 1 ise duvar, 2 ise geçilmiş yol,
                        // 3 ise geri dönülmüş ve bir daha gidilmeyecek yol, 4 ise bomba
                        switch (yön)
                        {
                            case 1://yön yukarı
                                if (y != 0)
                                {
                                    if ((Program.konum[x, y - 1] == 0) || (Program.konum[x, y - 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y--;
                                        yön = 1;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                        goto main;
                                    }
                                    else { goto a1; }
                                }
                            a1: if (x != 0)
                                {
                                    if ((Program.konum[x - 1, y] == 0) || (Program.konum[x - 1, y] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        x--;
                                        yön = 4;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı 
                                        goto main;
                                    }
                                    else { goto b1; }
                                }
                            b1: if ((Program.konum[x + 1, y] == 0) || (Program.konum[x + 1, y] == 4))
                                {
                                    Program.konum[x, y] = 2;
                                    x++;
                                    yön = 2;
                                    if (x == 29)
                                    {
                                        Program.konum[x, y] = 2;
                                        durum = 1;
                                    }//Çıkışa ulaştı 
                                    else if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                    goto main;
                                }
                                //Geri dönüyor
                                else if (y != 29)
                                {
                                    if (Program.konum[x, y + 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y++;
                                        yön = 3;
                                        goto main;
                                    }
                                    else { goto c1; }
                                }
                            c1: if (Program.konum[x + 1, y] == 2)
                                {
                                    Program.konum[x, y] = 3;
                                    x++;
                                    yön = 2;
                                    goto main;
                                }
                                else if (x != 0)
                                {
                                    if (Program.konum[x - 1, y] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        x--;
                                        yön = 4;
                                        goto main;
                                    }
                                    else { goto d1; }
                                }
                            d1: durum = 2;
                                break;
                            case 2:// yön sağa
                                if ((Program.konum[x + 1, y] == 0) || (Program.konum[x + 1, y] == 4))
                                {
                                    Program.konum[x, y] = 2;
                                    x++;
                                    yön = 2;
                                    if (x == 29)
                                    {
                                        Program.konum[x, y] = 0;
                                        durum = 1;
                                    }//Çıkışa ulaştı 
                                    else if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                    goto main;
                                }
                                else if (y != 0)
                                {
                                    if ((Program.konum[x, y - 1] == 0) || (Program.konum[x, y - 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y--;
                                        yön = 1;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                        goto main;
                                    }
                                    else { goto a2; }
                                }
                            a2: if (y != 29)
                                {
                                    if ((Program.konum[x, y + 1] == 0) || (Program.konum[x, y + 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y++;
                                        yön = 3;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı 
                                        goto main;
                                    }
                                    else { goto b2; }
                                }
                            //Geri dönüyor
                            b2: if (x != 0)
                                {
                                    if (Program.konum[x - 1, y] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        x--;
                                        yön = 4;
                                        goto main;
                                    }
                                    else { goto c2; }
                                }
                            c2: if (y != 29)
                                {
                                    if (Program.konum[x, y + 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y++;
                                        yön = 3;
                                        goto main;
                                    }
                                    else { goto d2; }
                                }
                            d2: if (y != 0)
                                {
                                    if (Program.konum[x, y - 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y--;
                                        yön = 1;
                                        goto main;
                                    }
                                    else { goto e2; }
                                }
                            e2: durum = 2;
                                break;
                            case 3://yön aşağı
                                if (y != 29)
                                {
                                    if ((Program.konum[x, y + 1] == 0) || (Program.konum[x, y + 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y++;
                                        yön = 3;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                        goto main;
                                    }
                                    else { goto a3; }
                                }
                            a3: if ((Program.konum[x + 1, y] == 0) || (Program.konum[x + 1, y] == 4))
                                {
                                    Program.konum[x, y] = 2;
                                    x++;
                                    yön = 2;
                                    if (x == 29)
                                    {
                                        Program.konum[x, y] = 0;
                                        durum = 1;
                                    }//Çıkışa ulaştı 
                                    else if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                    goto main;
                                }
                                else if (x != 0)
                                {
                                    if ((Program.konum[x - 1, y] == 0) || (Program.konum[x - 1, y] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        x--;
                                        yön = 4;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı 
                                        goto main;
                                    }
                                    else { goto b3; }
                                }
                            //Geri dönüyor
                            b3: if (y != 0)
                                {
                                    if (Program.konum[x, y - 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y--;
                                        yön = 1;
                                        goto main;
                                    }
                                    else { goto c3; }
                                }
                            c3: if (x != 0)
                                {
                                    if (Program.konum[x - 1, y] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        x--;
                                        yön = 4;
                                        goto main;
                                    }
                                    else { goto d3; }
                                }
                            d3: if (Program.konum[x + 1, y] == 2)
                                {
                                    Program.konum[x, y] = 3;
                                    x++;
                                    yön = 2;
                                    goto main;
                                }
                                else { durum = 2; }
                                break;
                            case 4://y sola
                                if (x != 0)
                                {
                                    if ((Program.konum[x - 1, y] == 0) || (Program.konum[x - 1, y] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        x--;
                                        yön = 4;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı 
                                        goto main;
                                    }
                                    else { goto a4; }
                                }
                            a4: if (y != 29)
                                {
                                    if ((Program.konum[x, y + 1] == 0) || (Program.konum[x, y + 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y++;
                                        yön = 3;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                        goto main;
                                    }
                                    else { goto b4; }
                                }
                            b4: if (y != 0)
                                {
                                    if ((Program.konum[x, y - 1] == 0) || (Program.konum[x, y - 1] == 4))
                                    {
                                        Program.konum[x, y] = 2;
                                        y--;
                                        yön = 1;
                                        if (Program.konum[x, y] == 4) { durum = 3; }//Bomba patladı
                                        goto main;
                                    }
                                    else { goto c4; }
                                }
                            //Geri dönüyor
                            c4: if (Program.konum[x + 1, y] == 2)
                                {
                                    Program.konum[x, y] = 3;
                                    x++;
                                    yön = 2;
                                    goto main;
                                }
                                else if (y != 0)
                                {
                                    if (Program.konum[x, y - 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y--;
                                        yön = 1;
                                        goto main;
                                    }
                                    else { goto d4; }
                                }
                            d4: if (y != 29)
                                {
                                    if (Program.konum[x, y + 1] == 2)
                                    {
                                        Program.konum[x, y] = 3;
                                        y++;
                                        yön = 3;
                                        goto main;
                                    }
                                    else { goto e4; }
                                }
                            e4: { durum = 2; }
                                break;
                        }
                    main:
                        Console.Write("");

                    }
                }
                else if (durum == 2) {
                    StartY++;
                    durum= 0; }
            }
            if (durum == 1)
            {
                Program.konum[x, y] = 2;
                Console.WriteLine("Labirent çıkış yolu bulundu!");
            }
            else if (durum == 3)
            {
                Console.Beep();
                Console.WriteLine("Labirentin çıkış yolunu bulmaya çalışan Gezgin, mayına basması sonucu hayatını kaybetti!");
            }
            else if (durum == 2)
                Console.WriteLine("Çıkış bulunamadı!");


        }
    }
}
