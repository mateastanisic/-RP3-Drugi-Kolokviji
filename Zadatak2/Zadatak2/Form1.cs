using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2
{
    //Izradila: Matea Stanišić

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prviLabel_Click(object sender, EventArgs e)
        {
            ColorDialog prviColorDijalog = new ColorDialog();
            DialogResult result = prviColorDijalog.ShowDialog();
            if( result == DialogResult.OK)
            {
                this.prviLabel.BackColor = prviColorDijalog.Color;
            }
        }

        private void drugiLabel_Click(object sender, EventArgs e)
        {
            ColorDialog drugiColorDijalog = new ColorDialog();
            DialogResult result = drugiColorDijalog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.drugiLabel.BackColor = drugiColorDijalog.Color;
            }
        }

        private void treciLabel_Click(object sender, EventArgs e)
        {
            ColorDialog treciColorDijalog = new ColorDialog();
            DialogResult result = treciColorDijalog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.treciLabel.BackColor = treciColorDijalog.Color;
            }
        }

        private void cetvrtiLabel_Click(object sender, EventArgs e)
        {
            ColorDialog cetvrtiColorDijalog = new ColorDialog();
            DialogResult result = cetvrtiColorDijalog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.cetvrtiLabel.BackColor = cetvrtiColorDijalog.Color;
            }
        }

        private void prikažiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 velicineProzora = new Form3();
            DialogResult result = velicineProzora.ShowDialog();
            if( velicineProzora.whichButton == "OK" && velicineProzora.widthTextBox.Text != "" && velicineProzora.heightTextBox.Text != "" )
            {
                int w,h;
                bool success = Int32.TryParse(velicineProzora.widthTextBox.Text, out w);
                if (!success)
                    return;
                success = Int32.TryParse(velicineProzora.heightTextBox.Text, out h);
                if (!success)
                    return;

                Form2 noviProzor = new Form2();
                noviProzor.Size = new Size(w, h);
                noviProzor.prviLabel.BackColor = this.prviLabel.BackColor;
                noviProzor.drugiLabel.BackColor = this.drugiLabel.BackColor;
                noviProzor.treciLabel.BackColor = this.treciLabel.BackColor;
                noviProzor.cetvrtiLabel.BackColor = this.cetvrtiLabel.BackColor;
                noviProzor.ShowDialog();
            }
        }
    }
}
