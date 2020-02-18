using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    //Izradila: Matea Stanišić

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void smanjiButton_Click(object sender, EventArgs e)
        {
            //čekaj dvije sekunde
            System.Threading.Thread.Sleep(2000);
            //nova visina prozora
            int newHeight = this.Height - (int)(0.2 * this.Height);

            //ako možemo još smanjiti
            if ( newHeight > this.MinimumSize.Height )
            {
                this.Height = newHeight;
            }
            else
            {
                MessageBox.Show("Ne možete više smanjiti visinu!");
            }
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int newButtonHeight = (int)(this.smanjiButton.Height / 2);
            if (newButtonHeight > 1)
            {
                this.smanjiButton.Height = newButtonHeight;
                this.MinimumSize = new Size(10, newButtonHeight + 40);
            }
            else
            {
                MessageBox.Show("Ne možete više smanjiti visinu gumba!");
            }
        }
    }
}
