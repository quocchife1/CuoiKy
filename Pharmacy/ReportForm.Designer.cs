namespace Pharmacy
{
    partial class ReportForm
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
            this.panelMonthlySale = new System.Windows.Forms.Panel();
            this.lblMonthlySale = new System.Windows.Forms.Label();
            this.panelRevenueEMP = new System.Windows.Forms.Panel();
            this.lblRevenueEMP = new System.Windows.Forms.Label();
            this.panelRevenueYear = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnRevenueEMP = new System.Windows.Forms.Button();
            this.btnRevenueYear = new System.Windows.Forms.Button();
            this.btnMontlySale = new System.Windows.Forms.Button();
            this.panelMonthlySale.SuspendLayout();
            this.panelRevenueEMP.SuspendLayout();
            this.panelRevenueYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMonthlySale
            // 
            this.panelMonthlySale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMonthlySale.Controls.Add(this.lblMonthlySale);
            this.panelMonthlySale.Controls.Add(this.btnMontlySale);
            this.panelMonthlySale.Location = new System.Drawing.Point(75, 316);
            this.panelMonthlySale.Name = "panelMonthlySale";
            this.panelMonthlySale.Size = new System.Drawing.Size(242, 183);
            this.panelMonthlySale.TabIndex = 1;
            // 
            // lblMonthlySale
            // 
            this.lblMonthlySale.AutoSize = true;
            this.lblMonthlySale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblMonthlySale.Location = new System.Drawing.Point(13, 132);
            this.lblMonthlySale.Name = "lblMonthlySale";
            this.lblMonthlySale.Size = new System.Drawing.Size(216, 22);
            this.lblMonthlySale.TabIndex = 1;
            this.lblMonthlySale.Text = "Doanh thu hằng tháng";
            // 
            // panelRevenueEMP
            // 
            this.panelRevenueEMP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRevenueEMP.Controls.Add(this.lblRevenueEMP);
            this.panelRevenueEMP.Controls.Add(this.btnRevenueEMP);
            this.panelRevenueEMP.Location = new System.Drawing.Point(502, 50);
            this.panelRevenueEMP.Name = "panelRevenueEMP";
            this.panelRevenueEMP.Size = new System.Drawing.Size(273, 183);
            this.panelRevenueEMP.TabIndex = 1;
            // 
            // lblRevenueEMP
            // 
            this.lblRevenueEMP.AutoSize = true;
            this.lblRevenueEMP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblRevenueEMP.Location = new System.Drawing.Point(12, 132);
            this.lblRevenueEMP.Name = "lblRevenueEMP";
            this.lblRevenueEMP.Size = new System.Drawing.Size(248, 22);
            this.lblRevenueEMP.TabIndex = 1;
            this.lblRevenueEMP.Text = "Doanh thu theo nhân viên";
            // 
            // panelRevenueYear
            // 
            this.panelRevenueYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRevenueYear.Controls.Add(this.lblYear);
            this.panelRevenueYear.Controls.Add(this.btnRevenueYear);
            this.panelRevenueYear.Location = new System.Drawing.Point(75, 50);
            this.panelRevenueYear.Name = "panelRevenueYear";
            this.panelRevenueYear.Size = new System.Drawing.Size(242, 183);
            this.panelRevenueYear.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblYear.Location = new System.Drawing.Point(20, 132);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(203, 22);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Doanh thu hằng năm";
            // 
            // btnRevenueEMP
            // 
            this.btnRevenueEMP.BackColor = System.Drawing.Color.White;
            this.btnRevenueEMP.BackgroundImage = global::Pharmacy.Properties.Resources.revenueEMP;
            this.btnRevenueEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRevenueEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueEMP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueEMP.ForeColor = System.Drawing.Color.White;
            this.btnRevenueEMP.Location = new System.Drawing.Point(86, 17);
            this.btnRevenueEMP.Name = "btnRevenueEMP";
            this.btnRevenueEMP.Size = new System.Drawing.Size(101, 97);
            this.btnRevenueEMP.TabIndex = 0;
            this.btnRevenueEMP.UseVisualStyleBackColor = false;
            this.btnRevenueEMP.Click += new System.EventHandler(this.btnRevenueEMP_Click);
            // 
            // btnRevenueYear
            // 
            this.btnRevenueYear.BackColor = System.Drawing.Color.White;
            this.btnRevenueYear.BackgroundImage = global::Pharmacy.Properties.Resources.revenueYear;
            this.btnRevenueYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRevenueYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueYear.ForeColor = System.Drawing.Color.White;
            this.btnRevenueYear.Location = new System.Drawing.Point(71, 17);
            this.btnRevenueYear.Name = "btnRevenueYear";
            this.btnRevenueYear.Size = new System.Drawing.Size(101, 97);
            this.btnRevenueYear.TabIndex = 0;
            this.btnRevenueYear.UseVisualStyleBackColor = false;
            this.btnRevenueYear.Click += new System.EventHandler(this.btnRevenueYear_Click);
            // 
            // btnMontlySale
            // 
            this.btnMontlySale.BackColor = System.Drawing.Color.White;
            this.btnMontlySale.BackgroundImage = global::Pharmacy.Properties.Resources.revenue1;
            this.btnMontlySale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMontlySale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontlySale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontlySale.ForeColor = System.Drawing.Color.White;
            this.btnMontlySale.Location = new System.Drawing.Point(71, 17);
            this.btnMontlySale.Name = "btnMontlySale";
            this.btnMontlySale.Size = new System.Drawing.Size(101, 97);
            this.btnMontlySale.TabIndex = 0;
            this.btnMontlySale.UseVisualStyleBackColor = false;
            this.btnMontlySale.Click += new System.EventHandler(this.btnMontlySale_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.panelRevenueEMP);
            this.Controls.Add(this.panelRevenueYear);
            this.Controls.Add(this.panelMonthlySale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.panelMonthlySale.ResumeLayout(false);
            this.panelMonthlySale.PerformLayout();
            this.panelRevenueEMP.ResumeLayout(false);
            this.panelRevenueEMP.PerformLayout();
            this.panelRevenueYear.ResumeLayout(false);
            this.panelRevenueYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMontlySale;
        private System.Windows.Forms.Panel panelMonthlySale;
        private System.Windows.Forms.Label lblMonthlySale;
        private System.Windows.Forms.Panel panelRevenueEMP;
        private System.Windows.Forms.Label lblRevenueEMP;
        private System.Windows.Forms.Button btnRevenueEMP;
        private System.Windows.Forms.Panel panelRevenueYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnRevenueYear;
    }
}