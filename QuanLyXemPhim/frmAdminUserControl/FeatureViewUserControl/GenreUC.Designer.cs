
namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    partial class GenreUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnInsertGenre = new System.Windows.Forms.Button();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel40);
            this.panel1.Controls.Add(this.dtgvGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 639);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel38);
            this.panel2.Controls.Add(this.panel39);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(708, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 575);
            this.panel2.TabIndex = 25;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtGenreName);
            this.panel38.Controls.Add(this.lblGenreName);
            this.panel38.Location = new System.Drawing.Point(4, 69);
            this.panel38.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(526, 54);
            this.panel38.TabIndex = 4;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(167, 10);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(329, 22);
            this.txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreName.Location = new System.Drawing.Point(4, 11);
            this.lblGenreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(134, 24);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Tên thể loại :";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.txtGenreID);
            this.panel39.Controls.Add(this.lblGenreID);
            this.panel39.Location = new System.Drawing.Point(4, 8);
            this.panel39.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(526, 54);
            this.panel39.TabIndex = 3;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Location = new System.Drawing.Point(167, 10);
            this.txtGenreID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(329, 22);
            this.txtGenreID.TabIndex = 1;
            this.txtGenreID.TextChanged += new System.EventHandler(this.txtGenreID_TextChanged);
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGenreID.Location = new System.Drawing.Point(4, 11);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(126, 24);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Mã thể loại :";
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.btnUpdateGenre);
            this.panel40.Controls.Add(this.btnDeleteGenre);
            this.panel40.Controls.Add(this.btnInsertGenre);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(1271, 64);
            this.panel40.TabIndex = 26;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Sửa";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click_1);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(112, 4);
            this.btnDeleteGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteGenre.TabIndex = 1;
            this.btnDeleteGenre.Text = "Xóa";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click_1);
            // 
            // btnInsertGenre
            // 
            this.btnInsertGenre.Location = new System.Drawing.Point(4, 4);
            this.btnInsertGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertGenre.Name = "btnInsertGenre";
            this.btnInsertGenre.Size = new System.Drawing.Size(100, 57);
            this.btnInsertGenre.TabIndex = 0;
            this.btnInsertGenre.Text = "Thêm";
            this.btnInsertGenre.UseVisualStyleBackColor = true;
            this.btnInsertGenre.Click += new System.EventHandler(this.btnInsertGenre_Click_1);
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.AllowUserToAddRows = false;
            this.dtgvGenre.AllowUserToDeleteRows = false;
            this.dtgvGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Location = new System.Drawing.Point(4, 72);
            this.dtgvGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.ReadOnly = true;
            this.dtgvGenre.RowHeadersWidth = 51;
            this.dtgvGenre.Size = new System.Drawing.Size(701, 570);
            this.dtgvGenre.TabIndex = 1;
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1271, 639);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel40.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnInsertGenre;
    }
}
