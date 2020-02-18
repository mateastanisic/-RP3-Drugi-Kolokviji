namespace Zadatak3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lijeviUkloniButton = new System.Windows.Forms.Button();
            this.lijeviDodajButton = new System.Windows.Forms.Button();
            this.desnoUkloniButton = new System.Windows.Forms.Button();
            this.desnoDodajButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.lijeviUkloniButton);
            this.splitContainer1.Panel1.Controls.Add(this.lijeviDodajButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.desnoUkloniButton);
            this.splitContainer1.Panel2.Controls.Add(this.desnoDodajButton);
            this.splitContainer1.Size = new System.Drawing.Size(812, 416);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // lijeviUkloniButton
            // 
            this.lijeviUkloniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lijeviUkloniButton.Location = new System.Drawing.Point(0, 23);
            this.lijeviUkloniButton.Name = "lijeviUkloniButton";
            this.lijeviUkloniButton.Size = new System.Drawing.Size(410, 23);
            this.lijeviUkloniButton.TabIndex = 1;
            this.lijeviUkloniButton.Text = "Ukloni";
            this.lijeviUkloniButton.UseVisualStyleBackColor = true;
            this.lijeviUkloniButton.Click += new System.EventHandler(this.lijeviUkloniButton_Click);
            // 
            // lijeviDodajButton
            // 
            this.lijeviDodajButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lijeviDodajButton.Location = new System.Drawing.Point(0, 0);
            this.lijeviDodajButton.Name = "lijeviDodajButton";
            this.lijeviDodajButton.Size = new System.Drawing.Size(410, 23);
            this.lijeviDodajButton.TabIndex = 0;
            this.lijeviDodajButton.Text = "Dodaj";
            this.lijeviDodajButton.UseVisualStyleBackColor = true;
            this.lijeviDodajButton.Click += new System.EventHandler(this.lijeviDodajButton_Click);
            // 
            // desnoUkloniButton
            // 
            this.desnoUkloniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.desnoUkloniButton.Location = new System.Drawing.Point(0, 23);
            this.desnoUkloniButton.Name = "desnoUkloniButton";
            this.desnoUkloniButton.Size = new System.Drawing.Size(398, 23);
            this.desnoUkloniButton.TabIndex = 3;
            this.desnoUkloniButton.Text = "Ukloni";
            this.desnoUkloniButton.UseVisualStyleBackColor = true;
            this.desnoUkloniButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // desnoDodajButton
            // 
            this.desnoDodajButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.desnoDodajButton.Location = new System.Drawing.Point(0, 0);
            this.desnoDodajButton.Name = "desnoDodajButton";
            this.desnoDodajButton.Size = new System.Drawing.Size(398, 23);
            this.desnoDodajButton.TabIndex = 2;
            this.desnoDodajButton.Text = "Dodaj";
            this.desnoDodajButton.UseVisualStyleBackColor = true;
            this.desnoDodajButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(42, 17);
            this.statusText.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Zadatak3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button lijeviUkloniButton;
        private System.Windows.Forms.Button lijeviDodajButton;
        private System.Windows.Forms.Button desnoUkloniButton;
        private System.Windows.Forms.Button desnoDodajButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
    }
}

