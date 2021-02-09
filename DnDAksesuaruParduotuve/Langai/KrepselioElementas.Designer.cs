
namespace DnDAksesuaruParduotuve
{
    partial class KrepselioElementas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pavadinimas = new System.Windows.Forms.Label();
            this.nuotrauka = new System.Windows.Forms.PictureBox();
            this.kiekis = new System.Windows.Forms.Label();
            this.kaina = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.daugiauNeturime = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nuotrauka)).BeginInit();
            this.SuspendLayout();
            // 
            // pavadinimas
            // 
            this.pavadinimas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pavadinimas.Location = new System.Drawing.Point(66, 14);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(146, 23);
            this.pavadinimas.TabIndex = 0;
            this.pavadinimas.Text = "Random prekė";
            // 
            // nuotrauka
            // 
            this.nuotrauka.Location = new System.Drawing.Point(12, 8);
            this.nuotrauka.Name = "nuotrauka";
            this.nuotrauka.Size = new System.Drawing.Size(48, 34);
            this.nuotrauka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuotrauka.TabIndex = 2;
            this.nuotrauka.TabStop = false;
            // 
            // kiekis
            // 
            this.kiekis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kiekis.Location = new System.Drawing.Point(286, 14);
            this.kiekis.Name = "kiekis";
            this.kiekis.Size = new System.Drawing.Size(47, 23);
            this.kiekis.TabIndex = 3;
            this.kiekis.Text = "99x";
            this.kiekis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kaina
            // 
            this.kaina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kaina.Location = new System.Drawing.Point(330, 14);
            this.kaina.Name = "kaina";
            this.kaina.Size = new System.Drawing.Size(84, 23);
            this.kaina.TabIndex = 5;
            this.kaina.Text = "99.99 €";
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.Control;
            this.minusButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.Location = new System.Drawing.Point(220, 10);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(30, 30);
            this.minusButton.TabIndex = 1;
            this.minusButton.Text = " -";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.Control;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.Location = new System.Drawing.Point(256, 10);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(30, 30);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // KrepselioElementas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.kaina);
            this.Controls.Add(this.kiekis);
            this.Controls.Add(this.nuotrauka);
            this.Controls.Add(this.pavadinimas);
            this.Name = "KrepselioElementas";
            this.Size = new System.Drawing.Size(420, 50);
            ((System.ComponentModel.ISupportInitialize)(this.nuotrauka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.PictureBox nuotrauka;
        private System.Windows.Forms.Label kiekis;
        private System.Windows.Forms.Label kaina;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.ToolTip daugiauNeturime;
    }
}
