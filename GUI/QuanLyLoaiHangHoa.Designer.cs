
namespace GUI
{
    partial class QuanLyLoaiHangHoa
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiHangHoa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHangHoa = new System.Windows.Forms.TextBox();
            this.dgvQuanLyLoaiHangHoa = new System.Windows.Forms.DataGridView();
            this.MaLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(857, 134);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quan Ly Loai Hang Hoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma loai hang hoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ten loai hang hoa";
            // 
            // txtMaLoaiHangHoa
            // 
            this.txtMaLoaiHangHoa.Location = new System.Drawing.Point(546, 135);
            this.txtMaLoaiHangHoa.Name = "txtMaLoaiHangHoa";
            this.txtMaLoaiHangHoa.Size = new System.Drawing.Size(219, 27);
            this.txtMaLoaiHangHoa.TabIndex = 4;
            // 
            // txtTenLoaiHangHoa
            // 
            this.txtTenLoaiHangHoa.Location = new System.Drawing.Point(546, 205);
            this.txtTenLoaiHangHoa.Name = "txtTenLoaiHangHoa";
            this.txtTenLoaiHangHoa.Size = new System.Drawing.Size(219, 27);
            this.txtTenLoaiHangHoa.TabIndex = 5;
            // 
            // dgvQuanLyLoaiHangHoa
            // 
            this.dgvQuanLyLoaiHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyLoaiHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiHangHoa,
            this.TenLoaiHangHoa});
            this.dgvQuanLyLoaiHangHoa.Location = new System.Drawing.Point(355, 363);
            this.dgvQuanLyLoaiHangHoa.Name = "dgvQuanLyLoaiHangHoa";
            this.dgvQuanLyLoaiHangHoa.RowHeadersWidth = 51;
            this.dgvQuanLyLoaiHangHoa.RowTemplate.Height = 29;
            this.dgvQuanLyLoaiHangHoa.Size = new System.Drawing.Size(596, 188);
            this.dgvQuanLyLoaiHangHoa.TabIndex = 6;
            this.dgvQuanLyLoaiHangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyLoaiHangHoa_RowEnter);
            // 
            // MaLoaiHangHoa
            // 
            this.MaLoaiHangHoa.DataPropertyName = "MaLoaiHangHoa";
            this.MaLoaiHangHoa.HeaderText = "Ma loai hang hoa";
            this.MaLoaiHangHoa.MinimumWidth = 6;
            this.MaLoaiHangHoa.Name = "MaLoaiHangHoa";
            this.MaLoaiHangHoa.Width = 200;
            // 
            // TenLoaiHangHoa
            // 
            this.TenLoaiHangHoa.DataPropertyName = "TenLoaiHangHoa";
            this.TenLoaiHangHoa.HeaderText = "Ten loai hang hoa";
            this.TenLoaiHangHoa.MinimumWidth = 6;
            this.TenLoaiHangHoa.Name = "TenLoaiHangHoa";
            this.TenLoaiHangHoa.Width = 200;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(857, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(857, 241);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(857, 294);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QuanLyLoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvQuanLyLoaiHangHoa);
            this.Controls.Add(this.txtTenLoaiHangHoa);
            this.Controls.Add(this.txtMaLoaiHangHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanLyLoaiHangHoa";
            this.Text = "Quan Ly Loai Hang Hoa";
            this.Load += new System.EventHandler(this.QuanLyLoaiHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaiHangHoa;
        private System.Windows.Forms.TextBox txtTenLoaiHangHoa;
        private System.Windows.Forms.DataGridView dgvQuanLyLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHangHoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}