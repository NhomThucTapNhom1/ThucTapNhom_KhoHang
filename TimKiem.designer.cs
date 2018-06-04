namespace QuanLyKhoHang
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(129, 77);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(162, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Maroon;
            this.btnTim.Location = new System.Drawing.Point(551, 77);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaLSP,
            this.MaHSX,
            this.Gia,
            this.BaoHanh,
            this.TinhNang});
            this.dgvTimKiem.Location = new System.Drawing.Point(50, 163);
            this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(616, 193);
            this.dgvTimKiem.TabIndex = 3;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // MaLSP
            // 
            this.MaLSP.DataPropertyName = "MaLSP";
            this.MaLSP.HeaderText = "Mã loại sản phẩm";
            this.MaLSP.Name = "MaLSP";
            // 
            // MaHSX
            // 
            this.MaHSX.DataPropertyName = "MaHSX";
            this.MaHSX.HeaderText = "Mã hãng SX";
            this.MaHSX.Name = "MaHSX";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // BaoHanh
            // 
            this.BaoHanh.DataPropertyName = "BaoHanh";
            this.BaoHanh.HeaderText = "Bảo hành";
            this.BaoHanh.Name = "BaoHanh";
            // 
            // TinhNang
            // 
            this.TinhNang.DataPropertyName = "TinhNang";
            this.TinhNang.HeaderText = "Tính năng";
            this.TinhNang.Name = "TinhNang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(48, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hiển thị";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tìm kiếm theo :";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.DisplayMember = "Mã sản phẩm";
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Loại sản phẩm",
            "Hang sản xuất"});
            this.cbTimKiem.Location = new System.Drawing.Point(403, 79);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(127, 21);
            this.cbTimKiem.TabIndex = 20;
            this.cbTimKiem.Tag = "Mã sản phẩm";
            this.cbTimKiem.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tìm kiếm sản phẩm";
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhNang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label label3;
    }
}