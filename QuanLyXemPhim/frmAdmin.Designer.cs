
namespace QuanLyXemPhim
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnAccountUC = new System.Windows.Forms.Button();
            this.btnCustomerUC = new System.Windows.Forms.Button();
            this.btnStaffUC = new System.Windows.Forms.Button();
            this.btnDataUC = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnAdmin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1832, 777);
            this.panel2.TabIndex = 2;
            // 
            // pnAdmin
            // 
            this.pnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdmin.Location = new System.Drawing.Point(0, 117);
            this.pnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1832, 660);
            this.pnAdmin.TabIndex = 2;
            this.pnAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAdmin_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnThongke);
            this.panel3.Controls.Add(this.btnAccountUC);
            this.panel3.Controls.Add(this.btnCustomerUC);
            this.panel3.Controls.Add(this.btnStaffUC);
            this.panel3.Controls.Add(this.btnDataUC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1832, 117);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.DarkViolet;
            this.btnThongke.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnThongke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnThongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnThongke.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThongke.Location = new System.Drawing.Point(751, 18);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(155, 79);
            this.btnThongke.TabIndex = 1;
            this.btnThongke.Text = "Doanh Thu";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAccountUC
            // 
            this.btnAccountUC.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAccountUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAccountUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAccountUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAccountUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAccountUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccountUC.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountUC.Image")));
            this.btnAccountUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAccountUC.Location = new System.Drawing.Point(574, 18);
            this.btnAccountUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccountUC.Name = "btnAccountUC";
            this.btnAccountUC.Size = new System.Drawing.Size(155, 79);
            this.btnAccountUC.TabIndex = 0;
            this.btnAccountUC.Text = "Tài Khoản";
            this.btnAccountUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAccountUC.UseVisualStyleBackColor = false;
            this.btnAccountUC.Click += new System.EventHandler(this.btnAccountUC_Click);
            // 
            // btnCustomerUC
            // 
            this.btnCustomerUC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCustomerUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCustomerUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomerUC.Image = global::QuanLyXemPhim.Properties.Resources.people_2_512;
            this.btnCustomerUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCustomerUC.Location = new System.Drawing.Point(402, 18);
            this.btnCustomerUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerUC.Name = "btnCustomerUC";
            this.btnCustomerUC.Size = new System.Drawing.Size(155, 79);
            this.btnCustomerUC.TabIndex = 0;
            this.btnCustomerUC.Text = "Khách Hàng";
            this.btnCustomerUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCustomerUC.UseVisualStyleBackColor = false;
            this.btnCustomerUC.Click += new System.EventHandler(this.btnCustomerUC_Click);
            // 
            // btnStaffUC
            // 
            this.btnStaffUC.BackColor = System.Drawing.Color.Olive;
            this.btnStaffUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnStaffUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffUC.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffUC.Image")));
            this.btnStaffUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStaffUC.Location = new System.Drawing.Point(226, 18);
            this.btnStaffUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffUC.Name = "btnStaffUC";
            this.btnStaffUC.Size = new System.Drawing.Size(155, 79);
            this.btnStaffUC.TabIndex = 0;
            this.btnStaffUC.Text = "Nhân Viên";
            this.btnStaffUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStaffUC.UseVisualStyleBackColor = false;
            this.btnStaffUC.Click += new System.EventHandler(this.btnStaffUC_Click);
            // 
            // btnDataUC
            // 
            this.btnDataUC.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDataUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDataUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDataUC.Image = global::QuanLyXemPhim.Properties.Resources.openfolder_4896;
            this.btnDataUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDataUC.Location = new System.Drawing.Point(47, 18);
            this.btnDataUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataUC.Name = "btnDataUC";
            this.btnDataUC.Size = new System.Drawing.Size(155, 79);
            this.btnDataUC.TabIndex = 0;
            this.btnDataUC.Text = "Dữ Liệu";
            this.btnDataUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDataUC.UseVisualStyleBackColor = false;
            this.btnDataUC.Click += new System.EventHandler(this.btnDataUC_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 777);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAccountUC;
        private System.Windows.Forms.Button btnCustomerUC;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnDataUC;
        //private System.Windows.Forms.Button btnRevenueUC;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.Button btnThongke;
    }
}