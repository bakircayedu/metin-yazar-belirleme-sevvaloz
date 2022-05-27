using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MetinYazariBelirlemeProjesi
{
    internal class Stack
    {
        public Cumle head;
        public int toplamSozcuk;

        //txt dosyasını stack'e dönüştürme
        public void TxtDonustur(string dosya)
        {
            string[] c;
            toplamSozcuk = 0;
            using (FileStream a = File.Open(dosya, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                c = temp.GetString(b).Split('\n');
                a.Close();
            }

            foreach (string item in c)
            {
                InsertStack(item.ToLower());
            }
        }

        public void InsertStack(string c)
        {
            Cumle temp = head;

            if (head == null)
            {
                head = new Cumle(c);
            }
            else
            {
                temp = new Cumle(c);
                temp.next = head;
                head = temp;
            }

            toplamSozcuk += head.sozcukSayisi;
        }

        public Tree TreeYap()
        {
            Cumle temp = head;
            Tree tree = new Tree(toplamSozcuk);
            bool eklendi = false;
            int sayac = 0;
            int eklenenSayisi = 0;

            while (temp != null)
            {
                for (int i = 0; i < temp.SozcukDizi.Length; i++)
                {
                    for (int j = 0; j < tree.heapDizi.Length; j++)
                    {
                        if (temp.SozcukDizi[i] == tree.heapDizi[j].sozcuk)
                        {
                            tree.heapDizi[j].sayi++;
                            //tree.heapDizi[j].Konumlar.Add(sayac + ". Cümle, " + i + ". Sözcük");
                            eklendi = true;
                            tree.Tasi(j);
                            break;
                        }
                    }
                    if (!eklendi)
                    {
                        tree.InsertTree(temp.SozcukDizi[i]);
                        //tree.heapDizi[eklenenSayisi].Konumlar.Add(sayac + ". Cümle, " + i + ". Sözcük");
                        eklenenSayisi++;
                    }
                    eklendi = false;
                }

                temp = temp.next;
                sayac++;
            }

            return tree;
        }
    }
}
