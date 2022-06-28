namespace CuaHangBanXeMay.Presentation
{
    partial class AdminFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.tb_matkhau = new System.Windows.Forms.MaskedTextBox();
            this.tb_tendangnhap = new System.Windows.Forms.TextBox();
            this.tb_loaitk = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_tim_tk = new System.Windows.Forms.TextBox();
            this.tb_tk_nv = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.MaskedTextBox();
            this.tb_sdt = new System.Windows.Forms.MaskedTextBox();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_tim_tk);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_loaitk);
            this.tabPage1.Controls.Add(this.tb_matkhau);
            this.tabPage1.Controls.Add(this.tb_tendangnhap);
            this.tabPage1.Controls.Add(this.dgv_taikhoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_manv);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_tk_nv);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb_diachi);
            this.tabPage2.Controls.Add(this.tb_sdt);
            this.tabPage2.Controls.Add(this.tb_tennv);
            this.tabPage2.Controls.Add(this.dgv_nv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(6, 59);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.Size = new System.Drawing.Size(568, 299);
            this.dgv_taikhoan.TabIndex = 0;
            this.dgv_taikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellClick);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(597, 147);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(153, 20);
            this.tb_matkhau.TabIndex = 1;
            // 
            // tb_tendangnhap
            // 
            this.tb_tendangnhap.Location = new System.Drawing.Point(597, 96);
            this.tb_tendangnhap.Name = "tb_tendangnhap";
            this.tb_tendangnhap.Size = new System.Drawing.Size(153, 20);
            this.tb_tendangnhap.TabIndex = 2;
            // 
            // tb_loaitk
            // 
            this.tb_loaitk.Location = new System.Drawing.Point(597, 196);
            this.tb_loaitk.Name = "tb_loaitk";
            this.tb_loaitk.Size = new System.Drawing.Size(153, 20);
            this.tb_loaitk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại tài khoản";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(421, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_tim_tk
            // 
            this.tb_tim_tk.Location = new System.Drawing.Point(6, 32);
            this.tb_tim_tk.Name = "tb_tim_tk";
            this.tb_tim_tk.Size = new System.Drawing.Size(409, 20);
            this.tb_tim_tk.TabIndex = 11;
            // 
            // tb_tk_nv
            // 
            this.tb_tk_nv.Location = new System.Drawing.Point(12, 42);
            this.tb_tk_nv.Name = "tb_tk_nv";
            this.tb_tk_nv.Size = new System.Drawing.Size(409, 20);
            this.tb_tk_nv.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(603, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(603, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Cập nhật";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(603, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(153, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên nhân viên";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(603, 251);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(153, 20);
            this.tb_diachi.TabIndex = 15;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(603, 202);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(153, 20);
            this.tb_sdt.TabIndex = 13;
            // 
            // tb_tennv
            // 
            this.tb_tennv.Location = new System.Drawing.Point(603, 151);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(153, 20);
            this.tb_tennv.TabIndex = 14;
            // 
            // dgv_nv
            // 
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Location = new System.Drawing.Point(12, 69);
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.Size = new System.Drawing.Size(568, 299);
            this.dgv_nv.TabIndex = 12;
            this.dgv_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nv_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã nhân viên: ";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(681, 104);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(0, 13);
            this.lb_manv.TabIndex = 25;
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminFrm";
            this.Text = "AdminFrm";
            this.Load += new System.EventHandler(this.AdminFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_loaitk;
        private System.Windows.Forms.MaskedTextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_tendangnhap;
        private System.Windows.Forms.TextBox tb_tim_tk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tk_nv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tb_diachi;
        private System.Windows.Forms.MaskedTextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tennv;
        private System.Windows.Forms.DataGridView dgv_nv;
    }
}