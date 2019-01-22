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
            this.lblAdvertissment = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.lblAddWord.Click += new System.EventHandler(this.label1_Click);
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
            // lblAdvertissment
            // 
            this.lblAdvertissment.AutoSize = true;
            this.lblAdvertissment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertissment.Location = new System.Drawing.Point(335, 243);
            this.lblAdvertissment.Name = "lblAdvertissment";
            this.lblAdvertissment.Size = new System.Drawing.Size(64, 25);
            this.lblAdvertissment.TabIndex = 6;
            this.lblAdvertissment.Text = "label1";
            this.lblAdvertissment.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(398, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblAdvertissment);
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
        private System.Windows.Forms.Label lblAdvertissment;
        private System.Windows.Forms.ListBox listBox1;
    }
}