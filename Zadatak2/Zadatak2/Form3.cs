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
    public partial class Form3 : Form
    {
        internal string whichButton = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            whichButton = "OK";
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            whichButton = "Cancel";
            this.Close();
        }
    }
}
