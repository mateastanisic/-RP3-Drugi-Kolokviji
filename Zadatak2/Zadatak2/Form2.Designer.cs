namespace Zadatak2
{
    partial class Form2
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
            this.cetvrtiLabel = new System.Windows.Forms.Label();
            this.treciLabel = new System.Windows.Forms.Label();
            this.drugiLabel = new System.Windows.Forms.Label();
            this.prviLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 464);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cetvrtiLabel
            // 
            this.cetvrtiLabel.AutoSize = true;
            this.cetvrtiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cetvrtiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetvrtiLabel.Location = new System.Drawing.Point(252, 232);
            this.cetvrtiLabel.Name = "cetvrtiLabel";
            this.cetvrtiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cetvrtiLabel.Size = new System.Drawing.Size(244, 232);
            this.cetvrtiLabel.TabIndex = 3;
            this.cetvrtiLabel.Text = "IV";
            this.cetvrtiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treciLabel
            // 
            this.treciLabel.AutoSize = true;
            this.treciLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treciLabel.Location = new System.Drawing.Point(3, 232);
            this.treciLabel.Name = "treciLabel";
            this.treciLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treciLabel.Size = new System.Drawing.Size(243, 232);
            this.treciLabel.TabIndex = 2;
            this.treciLabel.Text = "III";
            this.treciLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drugiLabel
            // 
            this.drugiLabel.AutoSize = true;
            this.drugiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugiLabel.Location = new System.Drawing.Point(252, 0);
            this.drugiLabel.Name = "drugiLabel";
            this.drugiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drugiLabel.Size = new System.Drawing.Size(244, 232);
            this.drugiLabel.TabIndex = 1;
            this.drugiLabel.Text = "II";
            this.drugiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prviLabel
            // 
            this.prviLabel.AutoSize = true;
            this.prviLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prviLabel.Location = new System.Drawing.Point(3, 0);
            this.prviLabel.Name = "prviLabel";
            this.prviLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prviLabel.Size = new System.Drawing.Size(243, 232);
            this.prviLabel.TabIndex = 0;
            this.prviLabel.Text = "I";
            this.prviLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Drugi Prozor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label cetvrtiLabel;
        internal System.Windows.Forms.Label treciLabel;
        internal System.Windows.Forms.Label drugiLabel;
        internal System.Windows.Forms.Label prviLabel;
    }
}