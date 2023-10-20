namespace KafeProjesi
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
            btnDetayEkle = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudAdet = new NumericUpDown();
            cboUrun = new ComboBox();
            cmbMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSiparisİptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            lblOdemeTutari = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(265, 26);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(75, 23);
            btnDetayEkle.TabIndex = 5;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.AllowUserToDeleteRows = false;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(12, 56);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(418, 343);
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
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(139, 27);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(120, 23);
            nudAdet.TabIndex = 4;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 27);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(121, 23);
            cboUrun.TabIndex = 3;
            // 
            // cmbMasaNo
            // 
            cmbMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMasaNo.FormattingEnabled = true;
            cmbMasaNo.Location = new Point(504, 27);
            cmbMasaNo.Name = "cmbMasaNo";
            cmbMasaNo.Size = new Size(121, 23);
            cmbMasaNo.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(631, 27);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(75, 23);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(139, 3);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(504, 3);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "Masa No";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(483, 260);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 10;
            label4.Text = "Ödeme Tutarı:";
            // 
            // btnSiparisİptal
            // 
            btnSiparisİptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisİptal.BackColor = Color.Brown;
            btnSiparisİptal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisİptal.Location = new Point(466, 304);
            btnSiparisİptal.Name = "btnSiparisİptal";
            btnSiparisİptal.Size = new Size(105, 60);
            btnSiparisİptal.TabIndex = 12;
            btnSiparisİptal.Text = "SİPARİŞ İPTAL";
            btnSiparisİptal.UseVisualStyleBackColor = false;
            btnSiparisİptal.Click += btnSiparisİptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.LimeGreen;
            btnOdemeAl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.Location = new Point(595, 304);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(105, 60);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Yellow;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfayaDon.Location = new Point(466, 370);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(234, 60);
            btnAnasayfayaDon.TabIndex = 14;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            btnAnasayfayaDon.Click += btnAnasayfayaDon_Click;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(597, 260);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(53, 21);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.Text = "₺ 0,00";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.LightSalmon;
            lblMasaNo.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.Control;
            lblMasaNo.Location = new Point(436, 56);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(270, 163);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 445);
            Controls.Add(lblMasaNo);
            Controls.Add(lblOdemeTutari);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisİptal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMasaTasi);
            Controls.Add(cmbMasaNo);
            Controls.Add(cboUrun);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Controls.Add(label1);
            MinimumSize = new Size(692, 453);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDetayEkle;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cboUrun;
        private ComboBox cmbMasaNo;
        private Button btnMasaTasi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSiparisİptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private Label lblOdemeTutari;
        private Label lblMasaNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}