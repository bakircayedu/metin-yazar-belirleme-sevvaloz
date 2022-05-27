using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirlemeProjesi
{
    internal class Cumle
    {
        public string cumle;
        public string[] SozcukDizi;
        public int sozcukSayisi = 0;
        public Cumle next;

        public Cumle(string c)
        {
            cumle = c;
            string[] Isaretler = { ".", ",", ";", ":", "?", "!", "(", ")", "-", "/" };
            
            foreach (string isaret in Isaretler)
            {
                cumle = cumle.Replace(isaret, "");
            }

            SozcukDizi = cumle.Split(' '); //cümleleri boşluğa göre sözcüklere ayır
            sozcukSayisi = SozcukDizi.Length;
        }
    }
}
