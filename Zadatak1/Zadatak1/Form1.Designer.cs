namespace Zadatak1
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
            this.smanjiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smanjiButton
            // 
            this.smanjiButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.smanjiButton.Location = new System.Drawing.Point(0, 0);
            this.smanjiButton.Name = "smanjiButton";
            this.smanjiButton.Size = new System.Drawing.Size(491, 50);
            this.smanjiButton.TabIndex = 0;
            this.smanjiButton.Text = "Smanji";
            this.smanjiButton.UseVisualStyleBackColor = true;
            this.smanjiButton.Click += new System.EventHandler(this.smanjiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 354);
            this.Controls.Add(this.smanjiButton);
            this.MinimumSize = new System.Drawing.Size(136, 89);
            this.Name = "Form1";
            this.Text = "Zadatak1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button smanjiButton;
    }
}

