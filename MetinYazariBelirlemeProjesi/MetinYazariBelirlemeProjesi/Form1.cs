using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazariBelirlemeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack stack = new Stack();
        Tree tree;

        //METİN YÜKLE
        private void buttonDosyaOku_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.ShowDialog();
            text.Text = file.FileName;
        }

        //STACK'E OKU
        private void buttonStackYap_Click(object sender, EventArgs e)
        {
            stack.TxtDonustur(text.Text);
        }

        //TREE'YE AKTAR
        private void buttonTreeYap_Click(object sender, EventArgs e)
        {
            tree = stack.TreeYap();
        }


        private void buttonGoster_Click(object sender, EventArgs e)
        {
            foreach (Sozcuk item in tree.heapDizi)
            {
                listView.Items.Add(item.sozcuk + " -> Kullanım Sayısı: " + item.sayi);
            }
        }
    }
}
