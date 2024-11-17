
namespace QuanLyXemPhim.frmAdminUserControl
{
    partial class FeatureViewUC
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnTicketsUC = new System.Windows.Forms.Button();
            this.btnShowTimesUC = new System.Windows.Forms.Button();
            this.btnMovieUC = new System.Windows.Forms.Button();
            this.btnGenreUC = new System.Windows.Forms.Button();
            this.btnCinema = new System.Windows.Forms.Button();
            this.pnData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnTicketsUC);
            this.panel1.Controls.Add(this.btnShowTimesUC);
            this.panel1.Controls.Add(this.btnMovieUC);
            this.panel1.Controls.Add(this.btnGenreUC);
            this.panel1.Controls.Add(this.btnCinema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 658);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 138);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 5;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnTicketsUC
            // 
            this.btnTicketsUC.FlatAppearance.BorderSize = 0;
            this.btnTicketsUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsUC.ForeColor = System.Drawing.Color.White;
            this.btnTicketsUC.Image = global::QuanLyXemPhim.Properties.Resources.Untitled_2_0008_Layer;
            this.btnTicketsUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicketsUC.Location = new System.Drawing.Point(15, 396);
            this.btnTicketsUC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicketsUC.Name = "btnTicketsUC";
            this.btnTicketsUC.Size = new System.Drawing.Size(263, 66);
            this.btnTicketsUC.TabIndex = 6;
            this.btnTicketsUC.Text = "       Vé";
            this.btnTicketsUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicketsUC.UseVisualStyleBackColor = true;
            this.btnTicketsUC.Click += new System.EventHandler(this.btnTicketsUC_Click);
            // 
            // btnShowTimesUC
            // 
            this.btnShowTimesUC.FlatAppearance.BorderSize = 0;
            this.btnShowTimesUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTimesUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTimesUC.ForeColor = System.Drawing.Color.White;
            this.btnShowTimesUC.Image = global::QuanLyXemPhim.Properties.Resources.Untitled_2_0002_Layer_7;
            this.btnShowTimesUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTimesUC.Location = new System.Drawing.Point(15, 334);
            this.btnShowTimesUC.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTimesUC.Name = "btnShowTimesUC";
            this.btnShowTimesUC.Size = new System.Drawing.Size(263, 66);
            this.btnShowTimesUC.TabIndex = 7;
            this.btnShowTimesUC.Text = "      Ca Chiếu";
            this.btnShowTimesUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTimesUC.UseVisualStyleBackColor = true;
            this.btnShowTimesUC.Click += new System.EventHandler(this.btnShowTimesUC_Click);
            // 
            // btnMovieUC
            // 
            this.btnMovieUC.FlatAppearance.BorderSize = 0;
            this.btnMovieUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieUC.ForeColor = System.Drawing.Color.White;
            this.btnMovieUC.Image = global::QuanLyXemPhim.Properties.Resources.Untitled_2_0005_Layer_4;
            this.btnMovieUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieUC.Location = new System.Drawing.Point(15, 271);
            this.btnMovieUC.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieUC.Name = "btnMovieUC";
            this.btnMovieUC.Size = new System.Drawing.Size(263, 66);
            this.btnMovieUC.TabIndex = 9;
            this.btnMovieUC.Text = "       Phim";
            this.btnMovieUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovieUC.UseVisualStyleBackColor = true;
            this.btnMovieUC.Click += new System.EventHandler(this.btnMovieUC_Click);
            // 
            // btnGenreUC
            // 
            this.btnGenreUC.FlatAppearance.BorderSize = 0;
            this.btnGenreUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenreUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreUC.ForeColor = System.Drawing.Color.White;
            this.btnGenreUC.Image = global::QuanLyXemPhim.Properties.Resources.Untitled_2_0003_Layer_6;
            this.btnGenreUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenreUC.Location = new System.Drawing.Point(15, 205);
            this.btnGenreUC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenreUC.Name = "btnGenreUC";
            this.btnGenreUC.Size = new System.Drawing.Size(263, 66);
            this.btnGenreUC.TabIndex = 10;
            this.btnGenreUC.Text = "      Thể Loại";
            this.btnGenreUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenreUC.UseVisualStyleBackColor = true;
            this.btnGenreUC.Click += new System.EventHandler(this.btnGenreUC_Click);
            // 
            // btnCinema
            // 
            this.btnCinema.FlatAppearance.BorderSize = 0;
            this.btnCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinema.ForeColor = System.Drawing.Color.White;
            this.btnCinema.Image = global::QuanLyXemPhim.Properties.Resources.Untitled_2_0007_Layer_2;
            this.btnCinema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCinema.Location = new System.Drawing.Point(15, 138);
            this.btnCinema.Margin = new System.Windows.Forms.Padding(4);
            this.btnCinema.Name = "btnCinema";
            this.btnCinema.Size = new System.Drawing.Size(263, 66);
            this.btnCinema.TabIndex = 11;
            this.btnCinema.Text = "       Phòng Chiếu";
            this.btnCinema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCinema.UseVisualStyleBackColor = true;
            this.btnCinema.Click += new System.EventHandler(this.btnCinema_Click);
            // 
            // pnData
            // 
            this.pnData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnData.Location = new System.Drawing.Point(279, 18);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(1551, 640);
            this.pnData.TabIndex = 1;
            // 
            // FeatureViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.panel1);
            this.Name = "FeatureViewUC";
            this.Size = new System.Drawing.Size(1830, 658);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnTicketsUC;
        private System.Windows.Forms.Button btnShowTimesUC;
        private System.Windows.Forms.Button btnMovieUC;
        private System.Windows.Forms.Button btnGenreUC;
        private System.Windows.Forms.Button btnCinema;
        private System.Windows.Forms.Panel pnData;
    }
}
