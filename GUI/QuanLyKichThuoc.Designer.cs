
namespace GUI
{
    partial class QuanLyKichThuoc
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvQuanLyKichThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKichThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(957, 161);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(957, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(957, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvQuanLyKichThuoc
            // 
            this.dgvQuanLyKichThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKichThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KichThuoc});
            this.dgvQuanLyKichThuoc.Location = new System.Drawing.Point(453, 325);
            this.dgvQuanLyKichThuoc.Name = "dgvQuanLyKichThuoc";
            this.dgvQuanLyKichThuoc.RowHeadersWidth = 51;
            this.dgvQuanLyKichThuoc.RowTemplate.Height = 29;
            this.dgvQuanLyKichThuoc.Size = new System.Drawing.Size(342, 188);
            this.dgvQuanLyKichThuoc.TabIndex = 4;
            this.dgvQuanLyKichThuoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKichThuoc_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quan Ly Kich Thuoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kich thuoc";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(621, 161);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(125, 27);
            this.txtKichThuoc.TabIndex = 8;
            // 
            // KichThuoc
            // 
            this.KichThuoc.DataPropertyName = "KichThuoc";
            this.KichThuoc.HeaderText = "Kich thuoc";
            this.KichThuoc.MinimumWidth = 6;
            this.KichThuoc.Name = "KichThuoc";
            this.KichThuoc.Width = 250;
            // 
            // QuanLyKichThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuanLyKichThuoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "QuanLyKichThuoc";
            this.Text = "Quan Ly Kich Thuoc";
            this.Load += new System.EventHandler(this.QuanLyKichThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKichThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvQuanLyKichThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
    }
}