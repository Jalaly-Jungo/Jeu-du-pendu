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
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.lblAddWord = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListBox();
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
            // txtAddWord
            // 
            this.txtAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWord.Location = new System.Drawing.Point(340, 36);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(206, 30);
            this.txtAddWord.TabIndex = 1;
            this.txtAddWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddWord_KeyPress);
            // 
            // lblAddWord
            // 
            this.lblAddWord.AutoSize = true;
            this.lblAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWord.Location = new System.Drawing.Point(209, 39);
            this.lblAddWord.Name = "lblAddWord";
            this.lblAddWord.Size = new System.Drawing.Size(125, 25);
            this.lblAddWord.TabIndex = 3;
            this.lblAddWord.Text = "Mot à ajouter";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(237, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Catégorie";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(626, 393);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(398, 110);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(120, 95);
            this.lstCategory.TabIndex = 7;
            // 
            // frmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAddWord);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.cmdAddWordsToHome);
            this.Name = "frmAddWord";
            this.Text = "AddWord";
            this.Load += new System.EventHandler(this.frmAddWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAddWordsToHome;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.Label lblAddWord;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstCategory;
    }
}