namespace QuanLyXemPhim
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 69);
            this.panel1.TabIndex = 4;
            // 
            // labelX
            // 
            this.labelX.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Yellow;
            this.labelX.Location = new System.Drawing.Point(0, 0);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(456, 69);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Welcome!";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(8, 115);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(97, 16);
            this.lblAccountInfo.TabIndex = 6;
            this.lblAccountInfo.Text = "Tên tài khoản : ";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnAdmin.Location = new System.Drawing.Point(116, 157);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(217, 91);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Quản Lý";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.BackColor = System.Drawing.Color.Silver;
            this.btnSeller.Location = new System.Drawing.Point(116, 256);
            this.btnSeller.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(217, 91);
            this.btnSeller.TabIndex = 7;
            this.btnSeller.Text = "Nhân Viên";
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSeller);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSeller;
    }
}