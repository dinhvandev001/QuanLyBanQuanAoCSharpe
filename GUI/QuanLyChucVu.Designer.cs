
namespace GUI
{
    partial class QuanLyChucVu
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
            this.txtXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvQuanLyChucVu = new System.Windows.Forms.DataGridView();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(874, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(874, 263);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(94, 29);
            this.txtXoa.TabIndex = 1;
            this.txtXoa.Text = "Xoa";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(874, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quan Ly Chuc Vu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ma chuc vu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ten chuc vu";
            // 
            // dgvQuanLyChucVu
            // 
            this.dgvQuanLyChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu});
            this.dgvQuanLyChucVu.Location = new System.Drawing.Point(290, 362);
            this.dgvQuanLyChucVu.Name = "dgvQuanLyChucVu";
            this.dgvQuanLyChucVu.RowHeadersWidth = 51;
            this.dgvQuanLyChucVu.RowTemplate.Height = 29;
            this.dgvQuanLyChucVu.Size = new System.Drawing.Size(633, 188);
            this.dgvQuanLyChucVu.TabIndex = 6;
            this.dgvQuanLyChucVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyChucVu_RowEnter);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Ma chuc vu";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Width = 150;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Ten chuc vu";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.Width = 150;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(513, 181);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(125, 27);
            this.txtMaChucVu.TabIndex = 7;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(513, 251);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(125, 27);
            this.txtTenChucVu.TabIndex = 8;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(874, 216);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // QuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.dgvQuanLyChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanLyChucVu";
            this.Text = "Quan Ly Chuc Vu";
            this.Load += new System.EventHandler(this.QuanLyChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvQuanLyChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.Button btnSua;
    }
}