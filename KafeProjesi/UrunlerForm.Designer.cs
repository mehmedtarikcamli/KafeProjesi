namespace KafeProjesi
{
    partial class UrunlerForm
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
            txtUrünAd = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            nudBirimFiyat = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // txtUrünAd
            // 
            txtUrünAd.Location = new Point(12, 43);
            txtUrünAd.Name = "txtUrünAd";
            txtUrünAd.Size = new Size(147, 23);
            txtUrünAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImageLayout = ImageLayout.None;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(278, 43);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 26);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 72);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.Size = new Size(530, 363);
            dgvUrunler.TabIndex = 3;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(165, 43);
            nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(107, 23);
            nudBirimFiyat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 5;
            label2.Text = "Birim Fiyatı(₺)";
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(label2);
            Controls.Add(nudBirimFiyat);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(txtUrünAd);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrünAd;
        private Label label1;
        private Button btnEkle;
        private DataGridView dgvUrunler;
        private NumericUpDown nudBirimFiyat;
        private Label label2;
    }
}