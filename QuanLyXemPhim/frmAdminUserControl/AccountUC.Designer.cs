
namespace QuanLyXemPhim.frmAdminUserControl
{
    partial class AccountUC
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
            this.components = new System.ComponentModel.Container();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnInsertAccount = new System.Windows.Forms.Button();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.Show_MK = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_idNV = new System.Windows.Forms.TextBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.toolTipAccountType = new System.Windows.Forms.ToolTip(this.components);
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(500, 172);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteAccount.TabIndex = 25;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(369, 172);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(91, 32);
            this.btnUpdateAccount.TabIndex = 26;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.Location = new System.Drawing.Point(217, 172);
            this.btnInsertAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(91, 32);
            this.btnInsertAccount.TabIndex = 27;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.UseVisualStyleBackColor = true;
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.Show_MK);
            this.grpAccount.Controls.Add(this.txt_Pass);
            this.grpAccount.Controls.Add(this.txt_idNV);
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(160, 2);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccount.Size = new System.Drawing.Size(604, 165);
            this.grpAccount.TabIndex = 22;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản";
            // 
            // Show_MK
            // 
            this.Show_MK.AutoSize = true;
            this.Show_MK.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_MK.Location = new System.Drawing.Point(452, 133);
            this.Show_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_MK.Name = "Show_MK";
            this.Show_MK.Size = new System.Drawing.Size(93, 22);
            this.Show_MK.TabIndex = 7;
            this.Show_MK.Text = "Mật Khẩu";
            this.Show_MK.UseMnemonic = false;
            this.Show_MK.UseVisualStyleBackColor = true;
            this.Show_MK.CheckedChanged += new System.EventHandler(this.Show_MK_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(436, 83);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(146, 34);
            this.txt_Pass.TabIndex = 8;
            // 
            // txt_idNV
            // 
            this.txt_idNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNV.Location = new System.Drawing.Point(137, 83);
            this.txt_idNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idNV.Name = "txt_idNV";
            this.txt_idNV.Size = new System.Drawing.Size(146, 30);
            this.txt_idNV.TabIndex = 7;
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(436, 27);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(141, 30);
            this.nudAccountType.TabIndex = 6;
            this.toolTipAccountType.SetToolTip(this.nudAccountType, "1 : Quản lý\r\n2 : Bán vé");
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(22, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:\r\n";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(137, 32);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName_Account.Location = new System.Drawing.Point(325, 88);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(97, 23);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Password:\r\n";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(325, 34);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(92, 23);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại TK: ";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(30, 86);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(178, 210);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 62;
            this.dtgvAccount.Size = new System.Drawing.Size(967, 382);
            this.dtgvAccount.TabIndex = 21;
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnInsertAccount);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.dtgvAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1400, 650);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnDeleteAccount;
		private System.Windows.Forms.Button btnUpdateAccount;
		private System.Windows.Forms.Button btnInsertAccount;
		private System.Windows.Forms.GroupBox grpAccount;
		private System.Windows.Forms.NumericUpDown nudAccountType;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblStaffName_Account;
		private System.Windows.Forms.Label lblAccountType;
		private System.Windows.Forms.Label lblStaffID_Account;
		private System.Windows.Forms.DataGridView dtgvAccount;
		private System.Windows.Forms.ToolTip toolTipAccountType;
        private System.Windows.Forms.TextBox txt_idNV;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.CheckBox Show_MK;
    }
}
