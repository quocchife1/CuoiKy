namespace Pharmacy
{
    partial class XacThuc
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
            this.lblXacThuc = new System.Windows.Forms.Label();
            this.lblTk = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.Label();
            this.lblOTP = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXacThuc
            // 
            this.lblXacThuc.AutoSize = true;
            this.lblXacThuc.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblXacThuc.Location = new System.Drawing.Point(128, 9);
            this.lblXacThuc.Name = "lblXacThuc";
            this.lblXacThuc.Size = new System.Drawing.Size(275, 34);
            this.lblXacThuc.TabIndex = 0;
            this.lblXacThuc.Text = "Xác thực tài khoản";
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblTk.Location = new System.Drawing.Point(48, 76);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(143, 22);
            this.lblTk.TabIndex = 1;
            this.lblTk.Text = "Tên tài khoản:";
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txtTK.Location = new System.Drawing.Point(274, 76);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(129, 22);
            this.txtTK.TabIndex = 1;
            this.txtTK.Text = "tên tài khoản";
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblOTP.Location = new System.Drawing.Point(48, 138);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(131, 22);
            this.lblOTP.TabIndex = 1;
            this.lblOTP.Text = "Mã xác thực:";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(233, 139);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(196, 20);
            this.txtOTP.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(52, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 44);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Xác thực";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.ForeColor = System.Drawing.Color.White;
            this.btnAgain.Location = new System.Drawing.Point(213, 225);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(118, 44);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Gửi lại";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(382, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // XacThuc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.lblXacThuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XacThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XacThuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXacThuc;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;
    }
}