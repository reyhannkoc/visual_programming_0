namespace son
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
            groupBox1 = new GroupBox();
            lstsag = new ListBox();
            lstsol = new ListBox();
            btnolustur = new Button();
            groupBox2 = new GroupBox();
            lblsonuc = new Label();
            cmbislemler = new ComboBox();
            lblislemler = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstsag);
            groupBox1.Controls.Add(lstsol);
            groupBox1.Controls.Add(btnolustur);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "1 ile 1000 arasında rastgele 20 sayı oluştur ve  sıralı bir şekilde listeleri doldur";
            // 
            // lstsag
            // 
            lstsag.FormattingEnabled = true;
            lstsag.Location = new Point(192, 102);
            lstsag.Name = "lstsag";
            lstsag.Size = new Size(150, 324);
            lstsag.TabIndex = 2;
            // 
            // lstsol
            // 
            lstsol.FormattingEnabled = true;
            lstsol.Location = new Point(19, 100);
            lstsol.Name = "lstsol";
            lstsol.Size = new Size(150, 324);
            lstsol.TabIndex = 1;
            // 
            // btnolustur
            // 
            btnolustur.BackColor = SystemColors.ActiveCaption;
            btnolustur.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnolustur.ForeColor = SystemColors.ActiveCaptionText;
            btnolustur.Location = new Point(121, 54);
            btnolustur.Name = "btnolustur";
            btnolustur.Size = new Size(94, 42);
            btnolustur.TabIndex = 0;
            btnolustur.Text = "Oluştur";
            btnolustur.UseVisualStyleBackColor = false;
            btnolustur.Click += btnolustur_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblsonuc);
            groupBox2.Controls.Add(cmbislemler);
            groupBox2.Controls.Add(lblislemler);
            groupBox2.Location = new Point(410, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hesapla";
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Location = new Point(34, 156);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(49, 20);
            lblsonuc.TabIndex = 2;
            lblsonuc.Text = "Sonuç";
            // 
            // cmbislemler
            // 
            cmbislemler.FormattingEnabled = true;
            cmbislemler.Location = new Point(151, 62);
            cmbislemler.Name = "cmbislemler";
            cmbislemler.Size = new Size(151, 28);
            cmbislemler.TabIndex = 1;
            cmbislemler.SelectedIndexChanged += cmbislemler_SelectedIndexChanged;
            // 
            // lblislemler
            // 
            lblislemler.AutoSize = true;
            lblislemler.Location = new Point(35, 63);
            lblislemler.Name = "lblislemler";
            lblislemler.Size = new Size(61, 20);
            lblislemler.TabIndex = 0;
            lblislemler.Text = "İşlemler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstsag;
        private ListBox lstsol;
        private Button btnolustur;
        private GroupBox groupBox2;
        private Label lblsonuc;
        private ComboBox cmbislemler;
        private Label lblislemler;
    }
}
