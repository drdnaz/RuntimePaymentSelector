namespace NisanOdev3
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
            lblSonuc = new Label();
            txtTutar = new TextBox();
            btnOde = new Button();
            cmbOdemeYontemi = new ComboBox();
            btnKlasorAra = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblSonuc
            // 
            lblSonuc.Location = new Point(183, 221);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(546, 101);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "SONUÇ";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(171, 145);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(328, 31);
            txtTutar.TabIndex = 1;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(37, 210);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(135, 74);
            btnOde.TabIndex = 2;
            btnOde.Text = "öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(180, 75);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(305, 33);
            cmbOdemeYontemi.TabIndex = 3;
            // 
            // btnKlasorAra
            // 
            btnKlasorAra.Location = new Point(37, 302);
            btnKlasorAra.Name = "btnKlasorAra";
            btnKlasorAra.Size = new Size(140, 80);
            btnKlasorAra.TabIndex = 4;
            btnKlasorAra.Text = "Klasör Ara";
            btnKlasorAra.UseVisualStyleBackColor = true;
            btnKlasorAra.Click += btnKlasorAra_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(37, 411);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(593, 254);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(listBox1);
            Controls.Add(btnKlasorAra);
            Controls.Add(cmbOdemeYontemi);
            Controls.Add(btnOde);
            Controls.Add(txtTutar);
            Controls.Add(lblSonuc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSonuc;
        private TextBox txtTutar;
        private Button btnOde;
        private ComboBox cmbOdemeYontemi;
        private Button btnKlasorAra;
        private ListBox listBox1;
    }
}
