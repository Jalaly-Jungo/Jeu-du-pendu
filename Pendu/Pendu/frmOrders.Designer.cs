namespace Pendu
{
    partial class frmOrders
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
            this.cmdOrdersBackHome = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOrdersBackHome
            // 
            this.cmdOrdersBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdersBackHome.Location = new System.Drawing.Point(12, 364);
            this.cmdOrdersBackHome.Name = "cmdOrdersBackHome";
            this.cmdOrdersBackHome.Size = new System.Drawing.Size(135, 35);
            this.cmdOrdersBackHome.TabIndex = 0;
            this.cmdOrdersBackHome.Text = "Menu";
            this.cmdOrdersBackHome.UseVisualStyleBackColor = true;
            this.cmdOrdersBackHome.Click += new System.EventHandler(this.cmdOrdersBackHome_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(294, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(143, 31);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Consignes";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 411);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.cmdOrdersBackHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consigne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOrdersBackHome;
        private System.Windows.Forms.Label lblOrder;
    }
}