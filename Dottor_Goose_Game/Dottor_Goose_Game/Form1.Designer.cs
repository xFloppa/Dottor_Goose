namespace Dottor_Goose_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.btnLancioDado = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 582);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(73, 22);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(50, 68);
            this.pictureBoxPlayer.TabIndex = 1;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // btnLancioDado
            // 
            this.btnLancioDado.Location = new System.Drawing.Point(48, 647);
            this.btnLancioDado.Name = "btnLancioDado";
            this.btnLancioDado.Size = new System.Drawing.Size(75, 23);
            this.btnLancioDado.TabIndex = 2;
            this.btnLancioDado.Text = "Dado";
            this.btnLancioDado.UseVisualStyleBackColor = true;
            this.btnLancioDado.Click += new System.EventHandler(this.btnLancioDado_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(329, 615);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(75, 23);
            this.btnResetGame.TabIndex = 3;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Location = new System.Drawing.Point(917, 615);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(75, 23);
            this.btnQuitGame.TabIndex = 4;
            this.btnQuitGame.Text = "Esci";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(437, 620);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 613);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnLancioDado);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dottor Goose Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Button btnLancioDado;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}

