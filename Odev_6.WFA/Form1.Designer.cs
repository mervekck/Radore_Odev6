namespace Odev_6.WFA
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
            cmbSec = new ComboBox();
            SuspendLayout();
            // 
            // cmbSec
            // 
            cmbSec.FormattingEnabled = true;
            cmbSec.Items.AddRange(new object[] { "Öğrenci Kayıt", "Araba Kayıt" });
            cmbSec.Location = new Point(105, 48);
            cmbSec.Name = "cmbSec";
            cmbSec.Size = new Size(274, 28);
            cmbSec.TabIndex = 0;
            cmbSec.SelectedIndexChanged += cmbSec_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 141);
            Controls.Add(cmbSec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSec;
    }
}
