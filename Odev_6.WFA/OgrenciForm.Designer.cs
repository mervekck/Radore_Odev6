namespace Odev_6.WFA
{
    partial class OgrenciForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtBolum = new TextBox();
            btnKayit = new Button();
            lblSonuc = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 69);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 147);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 226);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Bölüm";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(178, 66);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(326, 27);
            txtAdi.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(178, 144);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(326, 27);
            txtSoyadi.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(178, 223);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(326, 27);
            txtBolum.TabIndex = 5;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(282, 279);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(94, 29);
            btnKayit.TabIndex = 6;
            btnKayit.Text = "Kayıt";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.ForeColor = Color.Red;
            lblSonuc.Location = new Point(199, 317);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 19);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 8;
            label5.Text = "Öğrenci Kayıt";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(22, 13);
            button1.Name = "button1";
            button1.Size = new Size(41, 32);
            button1.TabIndex = 9;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OgrenciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 374);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lblSonuc);
            Controls.Add(btnKayit);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciForm";
            Text = "OgrenciForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtBolum;
        private Button btnKayit;
        private Label lblSonuc;
        private Label label5;
        private Button button1;
    }
}