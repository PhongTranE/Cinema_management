
namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    partial class TicketsUC
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
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.panel61 = new System.Windows.Forms.Panel();
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.panel61.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(652, 64);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(616, 565);
            this.lsvAllListShowTimes.TabIndex = 9;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.Click += new System.EventHandler(this.lsvAllListShowTimes_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Ca Chiếu";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phòng Chiếu";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái Chiếu";
            this.columnHeader4.Width = 100;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 64);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.Size = new System.Drawing.Size(644, 575);
            this.dtgvTicket.TabIndex = 18;
            this.dtgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTicket_CellContentClick);
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.btnAllListShowTimes);
            this.panel61.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(4);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(654, 64);
            this.panel61.TabIndex = 16;
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Location = new System.Drawing.Point(4, 7);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(154, 57);
            this.btnAllListShowTimes.TabIndex = 3;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            this.btnAllListShowTimes.UseVisualStyleBackColor = true;
            this.btnAllListShowTimes.Visible = false;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click_1);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(176, 7);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(154, 57);
            this.btnDeleteTicketsByShowTime.TabIndex = 1;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnDeleteTicketsByShowTime.Visible = false;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvAllListShowTimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 639);
            this.panel1.TabIndex = 17;
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.panel61);
            this.Controls.Add(this.panel1);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1271, 639);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.panel61.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dtgvTicket;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
