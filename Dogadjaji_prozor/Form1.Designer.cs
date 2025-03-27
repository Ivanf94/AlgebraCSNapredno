namespace Dogadjaji_prozor
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
            this.gumbVeliki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vucicBtn = new System.Windows.Forms.Button();
            this.brenaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumbVeliki
            // 
            this.gumbVeliki.Location = new System.Drawing.Point(110, 101);
            this.gumbVeliki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gumbVeliki.Name = "gumbVeliki";
            this.gumbVeliki.Size = new System.Drawing.Size(89, 41);
            this.gumbVeliki.TabIndex = 0;
            this.gumbVeliki.Text = "Klikni me";
            this.gumbVeliki.UseVisualStyleBackColor = true;
            this.gumbVeliki.Click += new System.EventHandler(this.gumbVeliki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daj glas kandidatu:";
            // 
            // vucicBtn
            // 
            this.vucicBtn.Location = new System.Drawing.Point(55, 300);
            this.vucicBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vucicBtn.Name = "vucicBtn";
            this.vucicBtn.Size = new System.Drawing.Size(120, 23);
            this.vucicBtn.TabIndex = 2;
            this.vucicBtn.Text = "Aleksandar Vučić";
            this.vucicBtn.UseVisualStyleBackColor = true;
            // 
            // brenaBtn
            // 
            this.brenaBtn.Location = new System.Drawing.Point(276, 300);
            this.brenaBtn.Name = "brenaBtn";
            this.brenaBtn.Size = new System.Drawing.Size(75, 23);
            this.brenaBtn.TabIndex = 3;
            this.brenaBtn.Text = "Lepa Brena";
            this.brenaBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 538);
            this.Controls.Add(this.brenaBtn);
            this.Controls.Add(this.vucicBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbVeliki);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbVeliki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vucicBtn;
        private System.Windows.Forms.Button brenaBtn;
    }
}

