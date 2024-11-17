
namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    partial class MovieUC
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
            this.clbMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.dtmMovieEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmMovieStart = new System.Windows.Forms.DateTimePicker();
            this.txtMovieYearLimit = new System.Windows.Forms.TextBox();
            this.txtMovieActor = new System.Windows.Forms.TextBox();
            this.txtMovieCountry = new System.Windows.Forms.TextBox();
            this.dtgvMovie = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownPhim = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtMovieDesc = new System.Windows.Forms.TextBox();
            this.lblMovieYearLimit = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieActor = new System.Windows.Forms.Label();
            this.lblMovieCountry = new System.Windows.Forms.Label();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).BeginInit();
            this.panel47.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbMovieGenre
            // 
            this.clbMovieGenre.CheckOnClick = true;
            this.clbMovieGenre.FormattingEnabled = true;
            this.clbMovieGenre.Location = new System.Drawing.Point(16, 150);
            this.clbMovieGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMovieGenre.MultiColumn = true;
            this.clbMovieGenre.Name = "clbMovieGenre";
            this.clbMovieGenre.Size = new System.Drawing.Size(304, 106);
            this.clbMovieGenre.TabIndex = 54;
            this.clbMovieGenre.SelectedIndexChanged += new System.EventHandler(this.clbMovieGenre_SelectedIndexChanged);
            // 
            // dtmMovieEnd
            // 
            this.dtmMovieEnd.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieEnd.Location = new System.Drawing.Point(678, 85);
            this.dtmMovieEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmMovieEnd.Name = "dtmMovieEnd";
            this.dtmMovieEnd.Size = new System.Drawing.Size(201, 22);
            this.dtmMovieEnd.TabIndex = 53;
            // 
            // dtmMovieStart
            // 
            this.dtmMovieStart.CustomFormat = "yyyy/MM/dd";
            this.dtmMovieStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieStart.Location = new System.Drawing.Point(678, 49);
            this.dtmMovieStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmMovieStart.Name = "dtmMovieStart";
            this.dtmMovieStart.Size = new System.Drawing.Size(201, 22);
            this.dtmMovieStart.TabIndex = 52;
            this.dtmMovieStart.Value = new System.DateTime(2024, 9, 10, 11, 56, 40, 0);
            // 
            // txtMovieYearLimit
            // 
            this.txtMovieYearLimit.Location = new System.Drawing.Point(678, 199);
            this.txtMovieYearLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieYearLimit.Name = "txtMovieYearLimit";
            this.txtMovieYearLimit.Size = new System.Drawing.Size(201, 22);
            this.txtMovieYearLimit.TabIndex = 50;
            // 
            // txtMovieActor
            // 
            this.txtMovieActor.Location = new System.Drawing.Point(678, 165);
            this.txtMovieActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieActor.Name = "txtMovieActor";
            this.txtMovieActor.Size = new System.Drawing.Size(201, 22);
            this.txtMovieActor.TabIndex = 49;
            // 
            // txtMovieCountry
            // 
            this.txtMovieCountry.Location = new System.Drawing.Point(678, 128);
            this.txtMovieCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieCountry.Name = "txtMovieCountry";
            this.txtMovieCountry.Size = new System.Drawing.Size(201, 22);
            this.txtMovieCountry.TabIndex = 48;
            // 
            // dtgvMovie
            // 
            this.dtgvMovie.AllowUserToAddRows = false;
            this.dtgvMovie.AllowUserToDeleteRows = false;
            this.dtgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMovie.Location = new System.Drawing.Point(0, 342);
            this.dtgvMovie.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvMovie.Name = "dtgvMovie";
            this.dtgvMovie.ReadOnly = true;
            this.dtgvMovie.RowHeadersWidth = 51;
            this.dtgvMovie.Size = new System.Drawing.Size(1271, 297);
            this.dtgvMovie.TabIndex = 1;
            this.dtgvMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMovie_CellClick);
            this.dtgvMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMovie_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownPhim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clbMovieGenre);
            this.panel2.Controls.Add(this.dtmMovieEnd);
            this.panel2.Controls.Add(this.dtmMovieStart);
            this.panel2.Controls.Add(this.txtMovieYearLimit);
            this.panel2.Controls.Add(this.txtMovieActor);
            this.panel2.Controls.Add(this.txtMovieCountry);
            this.panel2.Controls.Add(this.txtMovieLength);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.txtMovieDesc);
            this.panel2.Controls.Add(this.lblMovieYearLimit);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieActor);
            this.panel2.Controls.Add(this.lblMovieCountry);
            this.panel2.Controls.Add(this.lblMovieDesc);
            this.panel2.Controls.Add(this.txtMovieName);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.txtMovieID);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 278);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDownPhim
            // 
            this.numericUpDownPhim.Location = new System.Drawing.Point(678, 246);
            this.numericUpDownPhim.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownPhim.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPhim.Name = "numericUpDownPhim";
            this.numericUpDownPhim.Size = new System.Drawing.Size(201, 22);
            this.numericUpDownPhim.TabIndex = 3;
            this.numericUpDownPhim.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownPhim.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Năm SX";
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(678, 16);
            this.txtMovieLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(201, 22);
            this.txtMovieLength.TabIndex = 47;
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(505, 85);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(92, 23);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(505, 50);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(94, 23);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(505, 14);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(109, 23);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // txtMovieDesc
            // 
            this.txtMovieDesc.Location = new System.Drawing.Point(147, 90);
            this.txtMovieDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieDesc.Multiline = true;
            this.txtMovieDesc.Name = "txtMovieDesc";
            this.txtMovieDesc.Size = new System.Drawing.Size(201, 22);
            this.txtMovieDesc.TabIndex = 46;
            // 
            // lblMovieYearLimit
            // 
            this.lblMovieYearLimit.AutoSize = true;
            this.lblMovieYearLimit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYearLimit.Location = new System.Drawing.Point(504, 199);
            this.lblMovieYearLimit.Name = "lblMovieYearLimit";
            this.lblMovieYearLimit.Size = new System.Drawing.Size(166, 26);
            this.lblMovieYearLimit.TabIndex = 41;
            this.lblMovieYearLimit.Text = "Giới Hạn Tuổi:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(11, 123);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(103, 26);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieActor
            // 
            this.lblMovieActor.AutoSize = true;
            this.lblMovieActor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieActor.Location = new System.Drawing.Point(504, 161);
            this.lblMovieActor.Name = "lblMovieActor";
            this.lblMovieActor.Size = new System.Drawing.Size(115, 26);
            this.lblMovieActor.TabIndex = 39;
            this.lblMovieActor.Text = "Đạo Diễn:";
            // 
            // lblMovieCountry
            // 
            this.lblMovieCountry.AutoSize = true;
            this.lblMovieCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieCountry.Location = new System.Drawing.Point(504, 123);
            this.lblMovieCountry.Name = "lblMovieCountry";
            this.lblMovieCountry.Size = new System.Drawing.Size(118, 26);
            this.lblMovieCountry.TabIndex = 38;
            this.lblMovieCountry.Text = "Quốc Gia:";
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDesc.Location = new System.Drawing.Point(11, 85);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(81, 26);
            this.lblMovieDesc.TabIndex = 37;
            this.lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(147, 54);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(201, 22);
            this.txtMovieName.TabIndex = 51;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(11, 49);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(117, 26);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(147, 16);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(201, 22);
            this.txtMovieID.TabIndex = 45;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(11, 11);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(113, 26);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateMovie.TabIndex = 2;
            this.btnUpdateMovie.Text = "Sửa";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(112, 6);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(100, 55);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(4, 4);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(100, 57);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Thêm";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click_1);
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.btnUpdateMovie);
            this.panel47.Controls.Add(this.btnDeleteMovie);
            this.panel47.Controls.Add(this.btnAddMovie);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(0, 278);
            this.panel47.Margin = new System.Windows.Forms.Padding(4);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(1271, 64);
            this.panel47.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMovie);
            this.panel1.Controls.Add(this.panel47);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 639);
            this.panel1.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(1271, 639);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhim)).EndInit();
            this.panel47.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbMovieGenre;
        private System.Windows.Forms.DateTimePicker dtmMovieEnd;
        private System.Windows.Forms.DateTimePicker dtmMovieStart;
        private System.Windows.Forms.TextBox txtMovieYearLimit;
        private System.Windows.Forms.TextBox txtMovieActor;
        private System.Windows.Forms.TextBox txtMovieCountry;
        private System.Windows.Forms.DataGridView dtgvMovie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.TextBox txtMovieDesc;
        private System.Windows.Forms.Label lblMovieYearLimit;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieActor;
        private System.Windows.Forms.Label lblMovieCountry;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPhim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
