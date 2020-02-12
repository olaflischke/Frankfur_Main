using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BummlerUi
{
    public partial class Form1 : Form
    {
        Bummler bummler = new Bummler();

        public Form1()
        {
            InitializeComponent();


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = await bummler.BummelnAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.Text = await bummler.TroedelnAsync();
        }
    }
}
