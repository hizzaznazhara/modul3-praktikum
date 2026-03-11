namespace modul3_103022400047
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
            cbSatuanAwal = new ComboBox();
            cbSatuanAkhir = new ComboBox();
            txtNilaiAwal = new TextBox();
            txtNilaiAkhir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // cbSatuanAwal
            // 
            cbSatuanAwal.FormattingEnabled = true;
            cbSatuanAwal.Location = new Point(52, 86);
            cbSatuanAwal.Name = "cbSatuanAwal";
            cbSatuanAwal.Size = new Size(151, 28);
            cbSatuanAwal.TabIndex = 0;
            cbSatuanAwal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbSatuanAkhir
            // 
            cbSatuanAkhir.FormattingEnabled = true;
            cbSatuanAkhir.Location = new Point(52, 221);
            cbSatuanAkhir.Name = "cbSatuanAkhir";
            cbSatuanAkhir.Size = new Size(151, 28);
            cbSatuanAkhir.TabIndex = 1;
            cbSatuanAkhir.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtNilaiAwal
            // 
            txtNilaiAwal.Location = new Point(260, 87);
            txtNilaiAwal.Name = "txtNilaiAwal";
            txtNilaiAwal.Size = new Size(240, 27);
            txtNilaiAwal.TabIndex = 2;
            // 
            // txtNilaiAkhir
            // 
            txtNilaiAkhir.Location = new Point(260, 222);
            txtNilaiAkhir.Name = "txtNilaiAkhir";
            txtNilaiAkhir.ReadOnly = true;
            txtNilaiAkhir.Size = new Size(240, 27);
            txtNilaiAkhir.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 63);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 198);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Satuan Akhir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 63);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Nilai Awal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 198);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Nilai Akhir";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(569, 85);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 8;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNilaiAkhir);
            Controls.Add(txtNilaiAwal);
            Controls.Add(cbSatuanAkhir);
            Controls.Add(cbSatuanAwal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSatuanAwal;
        private ComboBox cbSatuanAkhir;
        private TextBox txtNilaiAwal;
        private TextBox txtNilaiAkhir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConvert;
    }
}
