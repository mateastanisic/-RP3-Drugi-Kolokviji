using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak3
{
    //Izradila: Matea Stanišić

    public partial class Form1 : Form
    {
        internal int ukupnoDodano = 0;
        internal int lijeviDodani = 0;
        internal int desniDodani = 0;
        internal int kolikoKlikova = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lijeviDodajButton_Click(object sender, EventArgs e)
        {
            lijeviDodani++;
            ukupnoDodano++;
            for(var i=1; i<=lijeviDodani; i++)
            {
                Button novi = new Button();
                novi.Text = "Gumb" + i;
                novi.Name = "Lgumb" + i;
                novi.Location = new Point(10, this.lijeviDodajButton.Height + this.lijeviUkloniButton.Height + i * novi.Height);
                splitContainer1.Panel1.Controls.Add(novi);
                novi.Click += new EventHandler(novododaniGumbi_Click);

            }
            this.statusText.Text = "Ukupno dodano: " + ukupnoDodano + ". Ukupno kliknuto: " + kolikoKlikova; 
        }

        private void novododaniGumbi_Click(object sender, EventArgs e)
        {
            kolikoKlikova++;
            Button button = sender as Button;
            string ime = button.Name.ToString();
            if ( String.Equals(ime[0],'L') )
            {
                MessageBox.Show("Na lijevoj strani, " + button.Text.ToString() );
            }
            else if (String.Equals(ime[0], 'D'))
            {
                MessageBox.Show("Na desnoj strani, " + button.Text.ToString());
            }

            this.statusText.Text = "Ukupno dodano: " + ukupnoDodano + ". Ukupno kliknuto: " + kolikoKlikova;
        }

        private void lijeviUkloniButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel1.Controls.OfType<Button>().ToList())
            {
                if (c.Text == "Ukloni" || c.Text == "Dodaj")
                    continue;

                splitContainer1.Panel1.Controls.Remove(c);
                c.Dispose();
            }
            lijeviDodani = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desniDodani++;
            ukupnoDodano++;
            for (var i = 1; i <= desniDodani ; i++)
            {
                Button novi = new Button();
                novi.Text = "Gumb" + i;
                novi.Name = "Dgumb" + i;
                novi.Location = new Point(10, this.desnoUkloniButton.Height + this.desnoDodajButton.Height + i * novi.Height);
                splitContainer1.Panel2.Controls.Add(novi);
                novi.Click += new EventHandler(novododaniGumbi_Click);
            }
            this.statusText.Text = "Ukupno dodano: " + ukupnoDodano + ". Ukupno kliknuto: " + kolikoKlikova;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls.OfType<Button>().ToList())
            {
                if (c.Text == "Ukloni" || c.Text == "Dodaj")
                    continue;

                splitContainer1.Panel2.Controls.Remove(c);
                c.Dispose();
            }
            desniDodani = 0;
        }

    }
}
