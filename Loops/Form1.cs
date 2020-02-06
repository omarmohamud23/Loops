using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see MessageBox dialogs?", "while", MessageBoxButtons.YesNo);

            while(selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here`s a Messagebox. Do you want another?", "while", MessageBoxButtons.YesNo);
            }

        }

        private void btnDowhile_Click(object sender, EventArgs e)
        {
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do while", MessageBoxButtons.YesNo);

            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int trknum = 5;
            for (int m = 0; m < trknum; m++)
            {
                MessageBox.Show("Here`s MessageBox" + m);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
