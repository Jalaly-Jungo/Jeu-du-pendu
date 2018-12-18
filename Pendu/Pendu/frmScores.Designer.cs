namespace Pendu
{
    partial class frmScores
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
            this.cmdScoresBackHome = new System.Windows.Forms.Button();
            this.lblScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdScoresBackHome
            // 
            this.cmdScoresBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScoresBackHome.Location = new System.Drawing.Point(12, 403);
            this.cmdScoresBackHome.Name = "cmdScoresBackHome";
            this.cmdScoresBackHome.Size = new System.Drawing.Size(135, 35);
            this.cmdScoresBackHome.TabIndex = 0;
            this.cmdScoresBackHome.Text = "Menu";
            this.cmdScoresBackHome.UseVisualStyleBackColor = true;
            this.cmdScoresBackHome.Click += new System.EventHandler(this.cmdScoresBackHome_Click);
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(332, 9);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(99, 31);
            this.lblScores.TabIndex = 1;
            this.lblScores.Text = "Scores";
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.cmdScoresBackHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scores";
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdScoresBackHome;
        private System.Windows.Forms.Label lblScores;
    }
}