namespace KafeOnline6
{
    partial class SiparisForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cboUrun = new ComboBox();
            nudAdet = new NumericUpDown();
            btnDetayEkle = new Button();
            btnMasaTasi = new Button();
            cboMasaNo = new ComboBox();
            label3 = new Label();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnaSayfayaDon = new Button();
            lblMasaNo = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 26);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Adet";
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(34, 46);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(121, 23);
            cboUrun.TabIndex = 1;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(206, 46);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(120, 23);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(366, 45);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(75, 23);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(756, 45);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(75, 23);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(622, 45);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(121, 23);
            cboMasaNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(646, 26);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 5;
            label3.Text = "Masa No";
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.AllowUserToDeleteRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(34, 85);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(450, 361);
            dgvDetaylar.TabIndex = 8;
            dgvDetaylar.KeyDown += dgvDetaylar_KeyDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün Ad";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Birim Fiyat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar TL";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(622, 266);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 10;
            label4.Text = "Ödeme Tutarı :";
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.Red;
            btnSiparisIptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = SystemColors.ButtonHighlight;
            btnSiparisIptal.Location = new Point(627, 305);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(81, 63);
            btnSiparisIptal.TabIndex = 12;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            btnSiparisIptal.Click += btnSiparisIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.LimeGreen;
            btnOdemeAl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = SystemColors.Control;
            btnOdemeAl.Location = new Point(756, 305);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(75, 63);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnaSayfayaDon.BackColor = Color.Yellow;
            btnAnaSayfayaDon.ForeColor = Color.Maroon;
            btnAnaSayfayaDon.Location = new Point(646, 374);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(153, 57);
            btnAnaSayfayaDon.TabIndex = 14;
            btnAnaSayfayaDon.Text = "ANA SAYFAYA DÖN";
            btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.Control;
            lblMasaNo.Location = new Point(622, 85);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(204, 153);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "00";
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.Location = new Point(756, 271);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(100, 23);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.Text = "₺0:00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 458);
            Controls.Add(lblOdemeTutari);
            Controls.Add(lblMasaNo);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(label4);
            Controls.Add(dgvDetaylar);
            Controls.Add(label3);
            Controls.Add(cboMasaNo);
            Controls.Add(btnMasaTasi);
            Controls.Add(btnDetayEkle);
            Controls.Add(nudAdet);
            Controls.Add(cboUrun);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnDetayEkle;
        private Button btnMasaTasi;
        private ComboBox cboMasaNo;
        private Label label3;
        private DataGridView dgvDetaylar;
        private Label label4;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnaSayfayaDon;
        private Label lblMasaNo;
        private Label lblOdemeTutari;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}