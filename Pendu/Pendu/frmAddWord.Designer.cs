namespace Pendu
{
    partial class frmAddWord
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
            this.cmdAddWordsToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAddWordsToHome
            // 
            this.cmdAddWordsToHome.Location = new System.Drawing.Point(66, 393);
            this.cmdAddWordsToHome.Name = "cmdAddWordsToHome";
            this.cmdAddWordsToHome.Size = new System.Drawing.Size(75, 23);
            this.cmdAddWordsToHome.TabIndex = 0;
            this.cmdAddWordsToHome.Text = "Menu";
            this.cmdAddWordsToHome.UseVisualStyleBackColor = true;
            this.cmdAddWordsToHome.Click += new System.EventHandler(this.cmdAddWordsToHome_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAddWordsToHome);
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAddWordsToHome;
    }
}