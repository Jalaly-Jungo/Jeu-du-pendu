namespace Pendu
{
    partial class frmHome
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
            this.lblNameGame = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOrders = new System.Windows.Forms.Button();
            this.cmdScores = new System.Windows.Forms.Button();
            this.cmdAddWords = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.Location = new System.Drawing.Point(381, 39);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(72, 13);
            this.lblNameGame.TabIndex = 0;
            this.lblNameGame.Text = "Jeu du pendu";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(378, 352);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Quitter";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdOrders
            // 
            this.cmdOrders.Location = new System.Drawing.Point(384, 289);
            this.cmdOrders.Name = "cmdOrders";
            this.cmdOrders.Size = new System.Drawing.Size(75, 23);
            this.cmdOrders.TabIndex = 2;
            this.cmdOrders.Text = "Consignes";
            this.cmdOrders.UseVisualStyleBackColor = true;
            this.cmdOrders.Click += new System.EventHandler(this.cmdOrders_Click);
            // 
            // cmdScores
            // 
            this.cmdScores.Location = new System.Drawing.Point(384, 232);
            this.cmdScores.Name = "cmdScores";
            this.cmdScores.Size = new System.Drawing.Size(75, 23);
            this.cmdScores.TabIndex = 3;
            this.cmdScores.Text = "Scores";
            this.cmdScores.UseVisualStyleBackColor = true;
            this.cmdScores.Click += new System.EventHandler(this.cmdScores_Click);
            // 
            // cmdAddWords
            // 
            this.cmdAddWords.Location = new System.Drawing.Point(378, 161);
            this.cmdAddWords.Name = "cmdAddWords";
            this.cmdAddWords.Size = new System.Drawing.Size(102, 39);
            this.cmdAddWords.TabIndex = 4;
            this.cmdAddWords.Text = "Ajouter un mot";
            this.cmdAddWords.UseVisualStyleBackColor = true;
            this.cmdAddWords.Click += new System.EventHandler(this.cmdAddWords_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(378, 87);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(75, 23);
            this.cmdPlay.TabIndex = 5;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdAddWords);
            this.Controls.Add(this.cmdScores);
            this.Controls.Add(this.cmdOrders);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblNameGame);
            this.Name = "frmHome";
            this.Text = "Jeu du pendu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOrders;
        private System.Windows.Forms.Button cmdScores;
        private System.Windows.Forms.Button cmdAddWords;
        private System.Windows.Forms.Button cmdPlay;
    }
}