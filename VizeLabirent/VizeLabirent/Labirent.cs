using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labirent
{
    internal class Labirent
    {
        static public void Oluştur() {
            Random sayiGen = new Random();
            int x = 0, y, direction = 2, dönsem_mi=0, leftRight, NeKadar;
            //yukarı 1, sağ 2, aşağı 3, sol 4
            for (int i=0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Program.konum[j, i] = 1;
                }
            }
            //Buraya
            //Başlangıç
            //Noktası ata
            y = sayiGen.Next(0, 30);
            Program.konum[0, y] = 0;
            do {
                switch (direction)
                {
                    case 1://yukarı
                        dönsem_mi = sayiGen.Next(0,4);
                        if ((dönsem_mi < 1) && (y != 0))
                        {
                            NeKadar = sayiGen.Next(3, 5);
                            for (int i = 0; i < NeKadar; i++)
                            {
                                if (y != 0)
                                {
                                    y--;
                                    Program.konum[x, y] = 0;
                                }
                                else { break; }
                            }
                        }
                        else if (dönsem_mi >= 1)
                        {
                            leftRight = sayiGen.Next(0, 3);
                            if (leftRight == 0)//solu
                            {
                                direction = 4;
                            }
                            else if(leftRight == 1)//sağı
                            {
                                direction = 2;
                            }
                            else if(leftRight== 2)//geri
                            {
                                direction = 3;
                            }
                        }
                        break;
                    case 2://sağa
                        dönsem_mi = sayiGen.Next(0, 4);
                        if (dönsem_mi < 1)
                        {
                            NeKadar = sayiGen.Next(3, 5);
                            for (int i = 0; i < NeKadar; i++)
                            {
                                if (x != 29)
                                {
                                    x++;
                                    Program.konum[x, y] = 0;
                                }
                                else { break; }
                            }
                        }
                        else if (dönsem_mi >= 1)
                        {
                            leftRight = sayiGen.Next(0, 3);
                            if (leftRight == 0)//solu
                            {
                                direction = 1;
                            }
                            else if (leftRight == 1)//sağı
                            {
                                direction = 3;
                            }
                            else if (leftRight == 2)//geri
                            {
                                direction = 4;
                            }
                        }
                        break;
                    case 3://aşağı
                        dönsem_mi = sayiGen.Next(0, 4);
                        if ((dönsem_mi < 1) && (y != 29))
                        {
                            NeKadar = sayiGen.Next(3, 5);
                            for (int i = 0; i < NeKadar; i++)
                            {
                                if (y != 29)
                                {
                                    y++;
                                    Program.konum[x, y] = 0;
                                }
                                else { break; }
                            }
                        }
                        else if (dönsem_mi >= 1)
                        {
                            leftRight = sayiGen.Next(0, 3);
                            if (leftRight == 0)//solu
                            {
                                direction = 2;
                            }
                            else if (leftRight == 1)//sağı
                            {
                                direction = 4;
                            }
                            else if (leftRight == 2)//geri
                            {
                                direction = 1;
                            }
                        }
                        break;
                    case 4://sola
                        dönsem_mi = sayiGen.Next(0, 4);
                        if ((dönsem_mi < 1) && (x != 0))
                        {
                            NeKadar = sayiGen.Next(3, 5);
                            for (int i = 0; i < NeKadar; i++)
                            {
                                if (x != 0)
                                {
                                    x--;
                                    Program.konum[x, y] = 0;
                                }
                                else { break; }
                            }
                        }
                        else if (dönsem_mi >= 1)
                        {
                            leftRight = sayiGen.Next(0, 3);
                            if (leftRight == 0)//solu
                            {
                                direction = 3;
                            }
                            else if (leftRight == 1)//sağı
                            {
                                direction = 1;
                            }
                            else if (leftRight == 2)//geri
                            {
                                direction = 2;
                            }
                        }
                        break;
                }

            } 
            while (x != 29);
            BombaYerlestirici();
        }
        public static void BombaYerlestirici() {
            Random sayiGen = new Random();
            int BombAmount = 3;
            int x=0, y=0;
            while (BombAmount != 0)
            {
                x = sayiGen.Next(1, 29);
                y = sayiGen.Next(0, 30);
                if (Program.konum[x, y] == 0)
                {
                    Program.konum[x, y] = 4;
                    BombAmount--;
                }
            }
        }
        
        
    }
}