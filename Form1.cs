using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_Pg355_ClassWithPlayingCard
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suits suit = (Suits)random.Next(4);
            Values value = (Values)random.Next(1, 13);
            Card card = new Card(suit, value);
            MessageBox.Show(card.Name);
        }
    }
}
