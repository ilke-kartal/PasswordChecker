namespace PasswordChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passlbl = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.annlbl = new System.Windows.Forms.Label();
            this.passStrMeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Location = new System.Drawing.Point(59, 148);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(81, 20);
            this.passlbl.TabIndex = 0;
            this.passlbl.Text = "Yeni Şifre : ";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(137, 145);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(245, 27);
            this.passtxt.TabIndex = 1;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // annlbl
            // 
            this.annlbl.Location = new System.Drawing.Point(12, 9);
            this.annlbl.Name = "annlbl";
            this.annlbl.Size = new System.Drawing.Size(463, 101);
            this.annlbl.TabIndex = 2;
            // 
            // passStrMeter
            // 
            this.passStrMeter.Location = new System.Drawing.Point(55, 128);
            this.passStrMeter.Name = "passStrMeter";
            this.passStrMeter.Size = new System.Drawing.Size(341, 72);
            this.passStrMeter.TabIndex = 3;
            this.passStrMeter.Text = "Lütfen sifrenizi giriniz.";
            this.passStrMeter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.annlbl);
            this.Controls.Add(this.passStrMeter);
            this.Name = "Form1";
            this.Text = "Password Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label passlbl;
        private TextBox passtxt;
        private Label annlbl;
        private Label passStrMeter;
    }
}