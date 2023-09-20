
namespace GUI
{
    partial class DanhSachDoanhSo
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachDoanhSo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonBanDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VonHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(936, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSachDoanhSo
            // 
            this.dgvDanhSachDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoDich,
            this.VonBanDau,
            this.VonHienTai,
            this.DoanhSo});
            this.dgvDanhSachDoanhSo.Location = new System.Drawing.Point(206, 334);
            this.dgvDanhSachDoanhSo.Name = "dgvDanhSachDoanhSo";
            this.dgvDanhSachDoanhSo.RowHeadersWidth = 51;
            this.dgvDanhSachDoanhSo.RowTemplate.Height = 29;
            this.dgvDanhSachDoanhSo.Size = new System.Drawing.Size(824, 288);
            this.dgvDanhSachDoanhSo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sach Doanh So";
            // 
            // MaGiaoDich
            // 
            this.MaGiaoDich.DataPropertyName = "MaGiaoDich";
            this.MaGiaoDich.HeaderText = "Ma giao dich";
            this.MaGiaoDich.MinimumWidth = 6;
            this.MaGiaoDich.Name = "MaGiaoDich";
            this.MaGiaoDich.Width = 150;
            // 
            // VonBanDau
            // 
            this.VonBanDau.DataPropertyName = "VonBanDau";
            this.VonBanDau.HeaderText = "Von ban dau";
            this.VonBanDau.MinimumWidth = 6;
            this.VonBanDau.Name = "VonBanDau";
            this.VonBanDau.Width = 150;
            // 
            // VonHienTai
            // 
            this.VonHienTai.DataPropertyName = "VonHienTai";
            this.VonHienTai.HeaderText = "Von hien tai";
            this.VonHienTai.MinimumWidth = 6;
            this.VonHienTai.Name = "VonHienTai";
            this.VonHienTai.Width = 150;
            // 
            // DoanhSo
            // 
            this.DoanhSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoanhSo.DataPropertyName = "DoanhSo";
            this.DoanhSo.HeaderText = "Doanh so";
            this.DoanhSo.MinimumWidth = 6;
            this.DoanhSo.Name = "DoanhSo";
            // 
            // DanhSachDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachDoanhSo);
            this.Controls.Add(this.btnThoat);
            this.Name = "DanhSachDoanhSo";
            this.Text = "Danh Sach Doanh So";
            this.Load += new System.EventHandler(this.DanhSachDoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachDoanhSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonBanDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn VonHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhSo;
    }
}