namespace Zadatak2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prviLabel = new System.Windows.Forms.Label();
            this.drugiLabel = new System.Windows.Forms.Label();
            this.treciLabel = new System.Windows.Forms.Label();
            this.cetvrtiLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikažiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cetvrtiLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.treciLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drugiLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.prviLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // prviLabel
            // 
            this.prviLabel.AutoSize = true;
            this.prviLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prviLabel.Location = new System.Drawing.Point(3, 0);
            this.prviLabel.Name = "prviLabel";
            this.prviLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prviLabel.Size = new System.Drawing.Size(317, 224);
            this.prviLabel.TabIndex = 0;
            this.prviLabel.Text = "I";
            this.prviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prviLabel.Click += new System.EventHandler(this.prviLabel_Click);
            // 
            // drugiLabel
            // 
            this.drugiLabel.AutoSize = true;
            this.drugiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugiLabel.Location = new System.Drawing.Point(326, 0);
            this.drugiLabel.Name = "drugiLabel";
            this.drugiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drugiLabel.Size = new System.Drawing.Size(317, 224);
            this.drugiLabel.TabIndex = 1;
            this.drugiLabel.Text = "II";
            this.drugiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drugiLabel.Click += new System.EventHandler(this.drugiLabel_Click);
            // 
            // treciLabel
            // 
            this.treciLabel.AutoSize = true;
            this.treciLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treciLabel.Location = new System.Drawing.Point(3, 224);
            this.treciLabel.Name = "treciLabel";
            this.treciLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treciLabel.Size = new System.Drawing.Size(317, 224);
            this.treciLabel.TabIndex = 2;
            this.treciLabel.Text = "III";
            this.treciLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.treciLabel.Click += new System.EventHandler(this.treciLabel_Click);
            // 
            // cetvrtiLabel
            // 
            this.cetvrtiLabel.AutoSize = true;
            this.cetvrtiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cetvrtiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetvrtiLabel.Location = new System.Drawing.Point(326, 224);
            this.cetvrtiLabel.Name = "cetvrtiLabel";
            this.cetvrtiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cetvrtiLabel.Size = new System.Drawing.Size(317, 224);
            this.cetvrtiLabel.TabIndex = 3;
            this.cetvrtiLabel.Text = "IV";
            this.cetvrtiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cetvrtiLabel.Click += new System.EventHandler(this.cetvrtiLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikažiToolStripMenuItem
            // 
            this.prikažiToolStripMenuItem.Name = "prikažiToolStripMenuItem";
            this.prikažiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.prikažiToolStripMenuItem.Text = "Prikaži";
            this.prikažiToolStripMenuItem.Click += new System.EventHandler(this.prikažiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(180, 153);
            this.Name = "Form1";
            this.Text = "Zadatak2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cetvrtiLabel;
        private System.Windows.Forms.Label treciLabel;
        private System.Windows.Forms.Label drugiLabel;
        private System.Windows.Forms.Label prviLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem;
    }
}

