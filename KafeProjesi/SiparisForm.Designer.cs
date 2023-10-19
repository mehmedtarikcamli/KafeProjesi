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
            label1 = new Label();
            btnDetayEkle = new Button();
            dataGridView1 = new DataGridView();
            nudAdet = new NumericUpDown();
            cmbUrün = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(372, 343);
            dataGridView1.TabIndex = 8;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(139, 27);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(120, 23);
            nudAdet.TabIndex = 4;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbUrün
            // 
            cmbUrün.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrün.FormattingEnabled = true;
            cmbUrün.Location = new Point(12, 27);
            cmbUrün.Name = "cmbUrün";
            cmbUrün.Size = new Size(121, 23);
            cmbUrün.TabIndex = 3;
            // 
            // cmbMasaNo
            // 
            cmbMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMasaNo.FormattingEnabled = true;
            cmbMasaNo.Location = new Point(463, 27);
            cmbMasaNo.Name = "cmbMasaNo";
            cmbMasaNo.Size = new Size(121, 23);
            cmbMasaNo.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(590, 27);
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
            label3.Location = new Point(463, 3);
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
            label4.Location = new Point(442, 245);
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
            btnSiparisİptal.Location = new Point(425, 273);
            btnSiparisİptal.Name = "btnSiparisİptal";
            btnSiparisİptal.Size = new Size(105, 60);
            btnSiparisİptal.TabIndex = 12;
            btnSiparisİptal.Text = "SİPARİŞ İPTAL";
            btnSiparisİptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.LimeGreen;
            btnOdemeAl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.Location = new Point(554, 273);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(105, 60);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Yellow;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfayaDon.Location = new Point(425, 339);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(234, 60);
            btnAnasayfayaDon.TabIndex = 14;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(556, 245);
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
            lblMasaNo.Location = new Point(395, 56);
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
            ClientSize = new Size(676, 414);
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
            Controls.Add(cmbUrün);
            Controls.Add(nudAdet);
            Controls.Add(dataGridView1);
            Controls.Add(btnDetayEkle);
            Controls.Add(label1);
            MinimumSize = new Size(692, 453);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDetayEkle;
        private DataGridView dataGridView1;
        private NumericUpDown nudAdet;
        private ComboBox cmbUrün;
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
    }
}