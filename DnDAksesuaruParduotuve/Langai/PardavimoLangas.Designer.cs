﻿
namespace DnDAksesuaruParduotuve
{
    partial class PardavimoLangas
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
            System.Windows.Forms.PictureBox DnDLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PardavimoLangas));
            this.AksesuaraiLogo = new System.Windows.Forms.Label();
            this.iseitiButton = new System.Windows.Forms.Button();
            this.griztiButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.DnDLogoPanel = new System.Windows.Forms.Panel();
            DnDLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(DnDLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DnDLogo
            // 
            DnDLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            DnDLogo.Image = ((System.Drawing.Image)(resources.GetObject("DnDLogo.Image")));
            DnDLogo.Location = new System.Drawing.Point(17, 19);
            DnDLogo.Name = "DnDLogo";
            DnDLogo.Size = new System.Drawing.Size(54, 33);
            DnDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            DnDLogo.TabIndex = 9;
            DnDLogo.TabStop = false;
            DnDLogo.Click += new System.EventHandler(this.Grizti);
            DnDLogo.MouseEnter += new System.EventHandler(this.DndLogo_MouseEnter);
            DnDLogo.MouseLeave += new System.EventHandler(this.DndLogo_MouseLeave);
            // 
            // AksesuaraiLogo
            // 
            this.AksesuaraiLogo.AutoSize = true;
            this.AksesuaraiLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AksesuaraiLogo.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AksesuaraiLogo.Location = new System.Drawing.Point(69, 20);
            this.AksesuaraiLogo.Name = "AksesuaraiLogo";
            this.AksesuaraiLogo.Size = new System.Drawing.Size(122, 30);
            this.AksesuaraiLogo.TabIndex = 10;
            this.AksesuaraiLogo.Text = "Aksesuarai";
            this.AksesuaraiLogo.Click += new System.EventHandler(this.Grizti);
            this.AksesuaraiLogo.MouseEnter += new System.EventHandler(this.DndLogo_MouseEnter);
            this.AksesuaraiLogo.MouseLeave += new System.EventHandler(this.DndLogo_MouseLeave);
            // 
            // iseitiButton
            // 
            this.iseitiButton.Location = new System.Drawing.Point(457, 458);
            this.iseitiButton.Name = "iseitiButton";
            this.iseitiButton.Size = new System.Drawing.Size(200, 47);
            this.iseitiButton.TabIndex = 2;
            this.iseitiButton.Text = "Išeiti";
            this.iseitiButton.UseVisualStyleBackColor = true;
            this.iseitiButton.Click += new System.EventHandler(this.Iseiti);
            // 
            // griztiButton
            // 
            this.griztiButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.griztiButton.Location = new System.Drawing.Point(237, 458);
            this.griztiButton.Name = "griztiButton";
            this.griztiButton.Size = new System.Drawing.Size(200, 47);
            this.griztiButton.TabIndex = 1;
            this.griztiButton.Text = "Grįžti į parduotuvę";
            this.griztiButton.UseVisualStyleBackColor = false;
            this.griztiButton.Click += new System.EventHandler(this.Grizti);
            // 
            // pardavimoInfo
            // 
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(235, 162);
            this.infoLabel.Name = "pardavimoInfo";
            this.infoLabel.Size = new System.Drawing.Size(427, 243);
            this.infoLabel.TabIndex = 20;
            this.infoLabel.Text = "Dėkojame, kad apsipirkote mūsų parduotuvėje!";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DnDLogoPanel
            // 
            this.DnDLogoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DnDLogoPanel.Location = new System.Drawing.Point(9, 10);
            this.DnDLogoPanel.Name = "DnDLogoPanel";
            this.DnDLogoPanel.Size = new System.Drawing.Size(185, 51);
            this.DnDLogoPanel.TabIndex = 30;
            this.DnDLogoPanel.Click += new System.EventHandler(this.Grizti);
            this.DnDLogoPanel.MouseEnter += new System.EventHandler(this.DndLogo_MouseEnter);
            this.DnDLogoPanel.MouseLeave += new System.EventHandler(this.DndLogo_MouseLeave);
            // 
            // PardavimoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 829);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.griztiButton);
            this.Controls.Add(this.iseitiButton);
            this.Controls.Add(this.AksesuaraiLogo);
            this.Controls.Add(DnDLogo);
            this.Controls.Add(this.DnDLogoPanel);
            this.MaximumSize = new System.Drawing.Size(913, 876);
            this.MinimumSize = new System.Drawing.Size(913, 876);
            this.Name = "PardavimoLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "D&D Aksesuarai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PardavimoLangas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(DnDLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AksesuaraiLogo;
        private System.Windows.Forms.Button iseitiButton;
        private System.Windows.Forms.Button griztiButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel DnDLogoPanel;
    }
}