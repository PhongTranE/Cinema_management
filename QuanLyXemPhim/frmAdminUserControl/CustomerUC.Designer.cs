
namespace QuanLyXemPhim.frmAdminUserControl
{
    partial class CustomerUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.numericUpDownNamSinh = new System.Windows.Forms.NumericUpDown();
            this.lblCusId = new System.Windows.Forms.Label();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.nudPoint = new System.Windows.Forms.NumericUpDown();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusBirth = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusPoint = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(485, 182);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(348, 182);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(91, 32);
            this.btnUpdateCustomer.TabIndex = 18;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(208, 182);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(91, 32);
            this.btnAddCustomer.TabIndex = 19;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click_1);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomer.Controls.Add(this.numericUpDownNamSinh);
            this.grpCustomer.Controls.Add(this.lblCusId);
            this.grpCustomer.Controls.Add(this.txtCusId);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.nudPoint);
            this.grpCustomer.Controls.Add(this.txtCusName);
            this.grpCustomer.Controls.Add(this.lblCusBirth);
            this.grpCustomer.Controls.Add(this.txtCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPoint);
            this.grpCustomer.Controls.Add(this.lblCusName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(208, 30);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Size = new System.Drawing.Size(971, 145);
            this.grpCustomer.TabIndex = 16;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // numericUpDownNamSinh
            // 
            this.numericUpDownNamSinh.Location = new System.Drawing.Point(167, 88);
            this.numericUpDownNamSinh.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownNamSinh.Name = "numericUpDownNamSinh";
            this.numericUpDownNamSinh.Size = new System.Drawing.Size(191, 30);
            this.numericUpDownNamSinh.TabIndex = 10;
            // 
            // lblCusId
            // 
            this.lblCusId.AutoSize = true;
            this.lblCusId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusId.Location = new System.Drawing.Point(767, 85);
            this.lblCusId.Name = "lblCusId";
            this.lblCusId.Size = new System.Drawing.Size(79, 23);
            this.lblCusId.TabIndex = 9;
            this.lblCusId.Text = "Mã KH:";
            // 
            // txtCusId
            // 
            this.txtCusId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusId.Location = new System.Drawing.Point(890, 81);
            this.txtCusId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(75, 30);
            this.txtCusId.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(512, 78);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(191, 30);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(421, 83);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // nudPoint
            // 
            this.nudPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPoint.Location = new System.Drawing.Point(890, 28);
            this.nudPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPoint.Name = "nudPoint";
            this.nudPoint.Size = new System.Drawing.Size(75, 30);
            this.nudPoint.TabIndex = 5;
            this.nudPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(167, 32);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(191, 30);
            this.txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            this.lblCusBirth.AutoSize = true;
            this.lblCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusBirth.Location = new System.Drawing.Point(50, 85);
            this.lblCusBirth.Name = "lblCusBirth";
            this.lblCusBirth.Size = new System.Drawing.Size(94, 23);
            this.lblCusBirth.TabIndex = 4;
            this.lblCusBirth.Text = "Năm sinh:";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhone.Location = new System.Drawing.Point(512, 29);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(191, 30);
            this.txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPhone.Location = new System.Drawing.Point(421, 31);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(69, 23);
            this.lblCusPhone.TabIndex = 4;
            this.lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            this.lblCusPoint.AutoSize = true;
            this.lblCusPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPoint.Location = new System.Drawing.Point(758, 28);
            this.lblCusPoint.Name = "lblCusPoint";
            this.lblCusPoint.Size = new System.Drawing.Size(128, 23);
            this.lblCusPoint.TabIndex = 4;
            this.lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(50, 39);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(73, 23);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Họ tên:";
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKhachHang,
            this.DiaChi,
            this.NamSinh,
            this.SoDienThoai,
            this.DiemTichLuy});
            this.dtgvCustomer.Location = new System.Drawing.Point(208, 218);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 24;
            this.dtgvCustomer.Size = new System.Drawing.Size(971, 372);
            this.dtgvCustomer.TabIndex = 14;
            this.dtgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellContentClick);
            this.dtgvCustomer.SelectionChanged += new System.EventHandler(this.dtgvCustomer_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.DataPropertyName = "DiemTichLuy";
            this.DiemTichLuy.HeaderText = "Điểm tích lũy";
            this.DiemTichLuy.MinimumWidth = 6;
            this.DiemTichLuy.Name = "DiemTichLuy";
            this.DiemTichLuy.ReadOnly = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(575, 344);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(8, 22);
            this.numericUpDown2.TabIndex = 20;
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.dtgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1400, 650);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.GroupBox grpCustomer;
		private System.Windows.Forms.NumericUpDown nudPoint;
		private System.Windows.Forms.TextBox txtCusName;
		private System.Windows.Forms.Label lblCusBirth;
		private System.Windows.Forms.TextBox txtCusPhone;
		private System.Windows.Forms.Label lblCusPhone;
		private System.Windows.Forms.Label lblCusPoint;
		private System.Windows.Forms.Label lblCusName;
		private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCusId;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTichLuy;
        private System.Windows.Forms.NumericUpDown numericUpDownNamSinh;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}
