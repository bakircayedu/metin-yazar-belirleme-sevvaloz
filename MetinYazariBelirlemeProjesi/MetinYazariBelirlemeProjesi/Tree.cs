using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirlemeProjesi
{
    internal class Tree
    {
        public Sozcuk[] heapDizi;
        public int boyut;
        public int maxBoyut;

        public Tree(int max)
        {
            maxBoyut = max;
            boyut = 0;
            heapDizi = new Sozcuk[boyut];
        }

        public bool IsEmpty()
        {
            return boyut == 0;
        }

        public int InsertTree(string s)
        {
            if(boyut == maxBoyut)
            {
                return 0;
            }
            else
            {
                Sozcuk newHeapDugumu = new Sozcuk(s);
                heapDizi[boyut] = newHeapDugumu;
                Tasi(boyut++);
                return 1;
            }
        }

        public void Tasi(int index)
        {
            int parent = (index - 1) / 2;
            Sozcuk bottom = heapDizi[index];
            while (index > 0 && heapDizi[parent].sayi < bottom.sayi)
            {
                heapDizi[index] = heapDizi[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapDizi[index] = bottom;
        }
    }
}
