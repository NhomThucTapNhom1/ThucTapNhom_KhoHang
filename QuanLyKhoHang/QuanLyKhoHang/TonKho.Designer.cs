namespace QuanLyKhoHang
{
    partial class TonKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTien1 = new System.Windows.Forms.TextBox();
            this.txtTong1 = new System.Windows.Forms.TextBox();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTien2 = new System.Windows.Forms.TextBox();
            this.txtTong2 = new System.Windows.Forms.TextBox();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTien3 = new System.Windows.Forms.TextBox();
            this.txtTong3 = new System.Windows.Forms.TextBox();
            this.dgvHangXuat = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 55);
            this.label1.TabIndex = 44;
            this.label1.Text = "THỐNG KÊ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 438);
            this.tabControl1.TabIndex = 66;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTien1);
            this.tabPage1.Controls.Add(this.txtTong1);
            this.tabPage1.Controls.Add(this.dgvTonKho);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(785, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kho hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(7, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tổng giá trị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(7, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tổng số lượng";
            // 
            // txtTien1
            // 
            this.txtTien1.Location = new System.Drawing.Point(167, 357);
            this.txtTien1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTien1.Name = "txtTien1";
            this.txtTien1.ReadOnly = true;
            this.txtTien1.Size = new System.Drawing.Size(165, 22);
            this.txtTien1.TabIndex = 69;
            // 
            // txtTong1
            // 
            this.txtTong1.Location = new System.Drawing.Point(167, 325);
            this.txtTong1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong1.Name = "txtTong1";
            this.txtTong1.ReadOnly = true;
            this.txtTong1.Size = new System.Drawing.Size(165, 22);
            this.txtTong1.TabIndex = 68;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Location = new System.Drawing.Point(11, 80);
            this.dgvTonKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.RowTemplate.Height = 24;
            this.dgvTonKho.Size = new System.Drawing.Size(763, 214);
            this.dgvTonKho.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(243, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 36);
            this.label4.TabIndex = 66;
            this.label4.Text = "Thông tin kho hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtTien2);
            this.tabPage2.Controls.Add(this.txtTong2);
            this.tabPage2.Controls.Add(this.dgvNhapHang);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(785, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hàng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(8, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tổng giá trị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(8, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tổng số lượng";
            // 
            // txtTien2
            // 
            this.txtTien2.Location = new System.Drawing.Point(168, 367);
            this.txtTien2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTien2.Name = "txtTien2";
            this.txtTien2.ReadOnly = true;
            this.txtTien2.Size = new System.Drawing.Size(165, 22);
            this.txtTien2.TabIndex = 75;
            // 
            // txtTong2
            // 
            this.txtTong2.Location = new System.Drawing.Point(168, 335);
            this.txtTong2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong2.Name = "txtTong2";
            this.txtTong2.ReadOnly = true;
            this.txtTong2.Size = new System.Drawing.Size(165, 22);
            this.txtTong2.TabIndex = 74;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(12, 96);
            this.dgvNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(763, 208);
            this.dgvNhapHang.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(161, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(432, 36);
            this.label7.TabIndex = 72;
            this.label7.Text = "Thông tin lượng nhập hàng hóa";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Azure;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtTien3);
            this.tabPage3.Controls.Add(this.txtTong3);
            this.tabPage3.Controls.Add(this.dgvHangXuat);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(785, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hàng xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(8, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tổng giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(8, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Tổng số lượng";
            // 
            // txtTien3
            // 
            this.txtTien3.Location = new System.Drawing.Point(168, 368);
            this.txtTien3.Margin = new System.Windows.Forms.Padding(4);
            this.txtTien3.Name = "txtTien3";
            this.txtTien3.ReadOnly = true;
            this.txtTien3.Size = new System.Drawing.Size(165, 22);
            this.txtTien3.TabIndex = 75;
            // 
            // txtTong3
            // 
            this.txtTong3.Location = new System.Drawing.Point(168, 336);
            this.txtTong3.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong3.Name = "txtTong3";
            this.txtTong3.ReadOnly = true;
            this.txtTong3.Size = new System.Drawing.Size(165, 22);
            this.txtTong3.TabIndex = 74;
            // 
            // dgvHangXuat
            // 
            this.dgvHangXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangXuat.Location = new System.Drawing.Point(12, 79);
            this.dgvHangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHangXuat.Name = "dgvHangXuat";
            this.dgvHangXuat.RowTemplate.Height = 24;
            this.dgvHangXuat.Size = new System.Drawing.Size(763, 230);
            this.dgvHangXuat.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(183, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 36);
            this.label10.TabIndex = 72;
            this.label10.Text = "Thông tin hàng hóa xuất kho";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(16, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 67;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(811, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TonKho";
            this.Text = "TonKho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTien1;
        private System.Windows.Forms.TextBox txtTong1;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTien2;
        private System.Windows.Forms.TextBox txtTong2;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTien3;
        private System.Windows.Forms.TextBox txtTong3;
        private System.Windows.Forms.DataGridView dgvHangXuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}