namespace Odev_6.WFA
{
    partial class ArabaForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            lblSonuc = new Label();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(37, 22);
            button1.Name = "button1";
            button1.Size = new Size(41, 32);
            button1.TabIndex = 10;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 11;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 155);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 12;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 28);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "Araba Kayıt";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(216, 90);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(285, 27);
            txtMarka.TabIndex = 14;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(216, 152);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(285, 27);
            txtModel.TabIndex = 15;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.ForeColor = Color.Red;
            lblSonuc.Location = new Point(200, 242);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 16;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(287, 208);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(94, 29);
            btnKayit.TabIndex = 17;
            btnKayit.Text = "Kayıt";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // ArabaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 314);
            Controls.Add(btnKayit);
            Controls.Add(lblSonuc);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ArabaForm";
            Text = "ArabaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label lblSonuc;
        private Button btnKayit;
    }
}