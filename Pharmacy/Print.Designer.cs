namespace Pharmacy
{
    partial class Print
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
            this.lblList = new System.Windows.Forms.Label();
            this.panelALL = new System.Windows.Forms.Panel();
            this.lblAllPrint = new System.Windows.Forms.Label();
            this.AllPrint = new System.Windows.Forms.PictureBox();
            this.panelmanagerPrint = new System.Windows.Forms.Panel();
            this.lblmanagerPrint = new System.Windows.Forms.Label();
            this.managerPrint = new System.Windows.Forms.PictureBox();
            this.panelempPrint = new System.Windows.Forms.Panel();
            this.lblempPrint = new System.Windows.Forms.Label();
            this.empPrint = new System.Windows.Forms.PictureBox();
            this.panelALL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPrint)).BeginInit();
            this.panelmanagerPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerPrint)).BeginInit();
            this.panelempPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblList.Location = new System.Drawing.Point(264, 43);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(222, 34);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "IN DANH SÁCH";
            // 
            // panelALL
            // 
            this.panelALL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelALL.Controls.Add(this.lblAllPrint);
            this.panelALL.Controls.Add(this.AllPrint);
            this.panelALL.Location = new System.Drawing.Point(12, 100);
            this.panelALL.Name = "panelALL";
            this.panelALL.Size = new System.Drawing.Size(215, 178);
            this.panelALL.TabIndex = 3;
            this.panelALL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelALL_MouseDown);
            this.panelALL.MouseLeave += new System.EventHandler(this.panelALL_MouseLeave);
            this.panelALL.MouseHover += new System.EventHandler(this.panelALL_MouseHover);
            this.panelALL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelALL_MouseUp);
            // 
            // lblAllPrint
            // 
            this.lblAllPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAllPrint.AutoSize = true;
            this.lblAllPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblAllPrint.Location = new System.Drawing.Point(73, 125);
            this.lblAllPrint.Name = "lblAllPrint";
            this.lblAllPrint.Size = new System.Drawing.Size(55, 19);
            this.lblAllPrint.TabIndex = 1;
            this.lblAllPrint.Text = "Tất cả";
            // 
            // AllPrint
            // 
            this.AllPrint.Image = global::Pharmacy.Properties.Resources.blank;
            this.AllPrint.Location = new System.Drawing.Point(72, 22);
            this.AllPrint.Name = "AllPrint";
            this.AllPrint.Size = new System.Drawing.Size(70, 76);
            this.AllPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AllPrint.TabIndex = 0;
            this.AllPrint.TabStop = false;
            // 
            // panelmanagerPrint
            // 
            this.panelmanagerPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelmanagerPrint.Controls.Add(this.lblmanagerPrint);
            this.panelmanagerPrint.Controls.Add(this.managerPrint);
            this.panelmanagerPrint.Location = new System.Drawing.Point(301, 100);
            this.panelmanagerPrint.Name = "panelmanagerPrint";
            this.panelmanagerPrint.Size = new System.Drawing.Size(215, 178);
            this.panelmanagerPrint.TabIndex = 3;
            this.panelmanagerPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmanagerPrint_MouseDown);
            this.panelmanagerPrint.MouseLeave += new System.EventHandler(this.panelmanagerPrint_MouseLeave);
            this.panelmanagerPrint.MouseHover += new System.EventHandler(this.panelmanagerPrint_MouseHover);
            this.panelmanagerPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmanagerPrint_MouseUp);
            // 
            // lblmanagerPrint
            // 
            this.lblmanagerPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmanagerPrint.AutoSize = true;
            this.lblmanagerPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagerPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblmanagerPrint.Location = new System.Drawing.Point(32, 125);
            this.lblmanagerPrint.Name = "lblmanagerPrint";
            this.lblmanagerPrint.Size = new System.Drawing.Size(151, 19);
            this.lblmanagerPrint.TabIndex = 1;
            this.lblmanagerPrint.Text = "Danh sách quản lý";
            // 
            // managerPrint
            // 
            this.managerPrint.Image = global::Pharmacy.Properties.Resources.managerPrint;
            this.managerPrint.Location = new System.Drawing.Point(72, 22);
            this.managerPrint.Name = "managerPrint";
            this.managerPrint.Size = new System.Drawing.Size(70, 76);
            this.managerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.managerPrint.TabIndex = 0;
            this.managerPrint.TabStop = false;
            // 
            // panelempPrint
            // 
            this.panelempPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelempPrint.Controls.Add(this.lblempPrint);
            this.panelempPrint.Controls.Add(this.empPrint);
            this.panelempPrint.Location = new System.Drawing.Point(589, 100);
            this.panelempPrint.Name = "panelempPrint";
            this.panelempPrint.Size = new System.Drawing.Size(215, 178);
            this.panelempPrint.TabIndex = 3;
            this.panelempPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelempPrint_MouseDown);
            this.panelempPrint.MouseLeave += new System.EventHandler(this.panelempPrint_MouseLeave);
            this.panelempPrint.MouseHover += new System.EventHandler(this.panelempPrint_MouseHover);
            this.panelempPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelempPrint_MouseUp);
            // 
            // lblempPrint
            // 
            this.lblempPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblempPrint.AutoSize = true;
            this.lblempPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblempPrint.Location = new System.Drawing.Point(22, 125);
            this.lblempPrint.Name = "lblempPrint";
            this.lblempPrint.Size = new System.Drawing.Size(170, 19);
            this.lblempPrint.TabIndex = 1;
            this.lblempPrint.Text = "Danh sách nhân viên";
            // 
            // empPrint
            // 
            this.empPrint.Image = global::Pharmacy.Properties.Resources.pharmacistPrint;
            this.empPrint.Location = new System.Drawing.Point(72, 22);
            this.empPrint.Name = "empPrint";
            this.empPrint.Size = new System.Drawing.Size(70, 76);
            this.empPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPrint.TabIndex = 0;
            this.empPrint.TabStop = false;
            // 
            // Print
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 714);
            this.Controls.Add(this.panelempPrint);
            this.Controls.Add(this.panelmanagerPrint);
            this.Controls.Add(this.panelALL);
            this.Controls.Add(this.lblList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Print";
            this.Text = "Print";
            this.panelALL.ResumeLayout(false);
            this.panelALL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPrint)).EndInit();
            this.panelmanagerPrint.ResumeLayout(false);
            this.panelmanagerPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerPrint)).EndInit();
            this.panelempPrint.ResumeLayout(false);
            this.panelempPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel panelALL;
        private System.Windows.Forms.PictureBox AllPrint;
        private System.Windows.Forms.Label lblAllPrint;
        private System.Windows.Forms.Panel panelmanagerPrint;
        private System.Windows.Forms.Label lblmanagerPrint;
        private System.Windows.Forms.PictureBox managerPrint;
        private System.Windows.Forms.Panel panelempPrint;
        private System.Windows.Forms.Label lblempPrint;
        private System.Windows.Forms.PictureBox empPrint;
    }
}