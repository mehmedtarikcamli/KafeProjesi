﻿namespace KafeProjesi
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            menuStrip1 = new MenuStrip();
            tsmiUrünler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            lvwMasalar = new ListView();
            ilMasalar = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrünler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrünler
            // 
            tsmiUrünler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiUrünler.Name = "tsmiUrünler";
            tsmiUrünler.Size = new Size(75, 25);
            tsmiUrünler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(142, 25);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            tsmiGecmisSiparisler.Click += tsmiGecmisSiparisler_Click;
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.LargeImageList = ilMasalar;
            lvwMasalar.Location = new Point(0, 29);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(800, 421);
            lvwMasalar.TabIndex = 1;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            lvwMasalar.DoubleClick += lvwMasalar_DoubleClick;
            // 
            // ilMasalar
            // 
            ilMasalar.ColorDepth = ColorDepth.Depth8Bit;
            ilMasalar.ImageStream = (ImageListStreamer)resources.GetObject("ilMasalar.ImageStream");
            ilMasalar.TransparentColor = Color.Transparent;
            ilMasalar.Images.SetKeyName(0, "bos");
            ilMasalar.Images.SetKeyName(1, "dolu");
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilkent Kafe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrünler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView lvwMasalar;
        private ImageList ilMasalar;
    }
}