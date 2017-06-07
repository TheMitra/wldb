namespace wldb
{
    partial class wldbForm
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
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLoss = new System.Windows.Forms.Button();
            this.lblHero = new System.Windows.Forms.Label();
            this.cbHero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(135, 67);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(93, 47);
            this.btnWin.TabIndex = 1;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            // 
            // btnLoss
            // 
            this.btnLoss.Location = new System.Drawing.Point(249, 67);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(93, 47);
            this.btnLoss.TabIndex = 2;
            this.btnLoss.Text = "Loss";
            this.btnLoss.UseVisualStyleBackColor = true;
            // 
            // lblHero
            // 
            this.lblHero.AutoSize = true;
            this.lblHero.Location = new System.Drawing.Point(132, 40);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(43, 17);
            this.lblHero.TabIndex = 3;
            this.lblHero.Text = "Hero:";
            // 
            // cbHero
            // 
            this.cbHero.FormattingEnabled = true;
            this.cbHero.Items.AddRange(new object[] {
            "Genji",
            "McCree",
            "Pharah",
            "Reaper",
            "Soldier: 76",
            "Sombra",
            "Tracer",
            "Bastion",
            "Hanzo",
            "Junkrat",
            "Mei",
            "Torbjörn",
            "Widowmaker",
            "D. Va",
            "Orisa",
            "Reinhardt",
            "Roadhog",
            "Winston",
            "Zarya",
            "Ana",
            "Lúcio",
            "Mercy",
            "Symmetra",
            "Zenyatta"});
            this.cbHero.Location = new System.Drawing.Point(182, 36);
            this.cbHero.Name = "cbHero";
            this.cbHero.Size = new System.Drawing.Size(160, 24);
            this.cbHero.TabIndex = 4;
            this.cbHero.Text = "Pick one";
            // 
            // wldbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 142);
            this.Controls.Add(this.cbHero);
            this.Controls.Add(this.lblHero);
            this.Controls.Add(this.btnLoss);
            this.Controls.Add(this.btnWin);
            this.Name = "wldbForm";
            this.Text = "Win Loss DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLoss;
        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.ComboBox cbHero;
    }
}

