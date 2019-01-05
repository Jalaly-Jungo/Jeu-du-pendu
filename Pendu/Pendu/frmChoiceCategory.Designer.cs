namespace Pendu
{
    partial class frmChoiceCategory
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
            this.cmdSport = new System.Windows.Forms.Button();
            this.cmdCelebrity = new System.Windows.Forms.Button();
            this.cmdFruit = new System.Windows.Forms.Button();
            this.cmdCar = new System.Windows.Forms.Button();
            this.cmdStone = new System.Windows.Forms.Button();
            this.cmdIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSport
            // 
            this.cmdSport.Location = new System.Drawing.Point(188, 166);
            this.cmdSport.Name = "cmdSport";
            this.cmdSport.Size = new System.Drawing.Size(87, 28);
            this.cmdSport.TabIndex = 0;
            this.cmdSport.Text = "Sport";
            this.cmdSport.UseVisualStyleBackColor = true;
            // 
            // cmdCelebrity
            // 
            this.cmdCelebrity.Location = new System.Drawing.Point(347, 165);
            this.cmdCelebrity.Name = "cmdCelebrity";
            this.cmdCelebrity.Size = new System.Drawing.Size(82, 29);
            this.cmdCelebrity.TabIndex = 1;
            this.cmdCelebrity.Text = "Célébrité";
            this.cmdCelebrity.UseVisualStyleBackColor = true;
            // 
            // cmdFruit
            // 
            this.cmdFruit.Location = new System.Drawing.Point(517, 165);
            this.cmdFruit.Name = "cmdFruit";
            this.cmdFruit.Size = new System.Drawing.Size(76, 29);
            this.cmdFruit.TabIndex = 2;
            this.cmdFruit.Text = "Fruit";
            this.cmdFruit.UseVisualStyleBackColor = true;
            // 
            // cmdCar
            // 
            this.cmdCar.Location = new System.Drawing.Point(198, 228);
            this.cmdCar.Name = "cmdCar";
            this.cmdCar.Size = new System.Drawing.Size(77, 28);
            this.cmdCar.TabIndex = 3;
            this.cmdCar.Text = "Voitures";
            this.cmdCar.UseVisualStyleBackColor = true;
            // 
            // cmdStone
            // 
            this.cmdStone.Location = new System.Drawing.Point(347, 231);
            this.cmdStone.Name = "cmdStone";
            this.cmdStone.Size = new System.Drawing.Size(82, 25);
            this.cmdStone.TabIndex = 4;
            this.cmdStone.Text = "Caillou";
            this.cmdStone.UseVisualStyleBackColor = true;
            // 
            // cmdIT
            // 
            this.cmdIT.Location = new System.Drawing.Point(517, 228);
            this.cmdIT.Name = "cmdIT";
            this.cmdIT.Size = new System.Drawing.Size(76, 28);
            this.cmdIT.TabIndex = 5;
            this.cmdIT.Text = "I.T.";
            this.cmdIT.UseVisualStyleBackColor = true;
            // 
            // frmChoiceCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdIT);
            this.Controls.Add(this.cmdStone);
            this.Controls.Add(this.cmdCar);
            this.Controls.Add(this.cmdFruit);
            this.Controls.Add(this.cmdCelebrity);
            this.Controls.Add(this.cmdSport);
            this.Name = "frmChoiceCategory";
            this.Text = "frmChoiceCategory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSport;
        private System.Windows.Forms.Button cmdCelebrity;
        private System.Windows.Forms.Button cmdFruit;
        private System.Windows.Forms.Button cmdCar;
        private System.Windows.Forms.Button cmdStone;
        private System.Windows.Forms.Button cmdIT;
    }
}