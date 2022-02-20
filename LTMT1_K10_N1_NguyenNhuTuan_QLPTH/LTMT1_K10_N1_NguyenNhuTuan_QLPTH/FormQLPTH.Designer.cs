namespace LTMT1_K10_N1_NguyenNhuTuan_QLPTH
{
    partial class FormQLPTH
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
            this.txtgiaovien = new System.Windows.Forms.TextBox();
            this.buoiTH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayTH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbbuoi = new System.Windows.Forms.ComboBox();
            this.cmbmonhoc = new System.Windows.Forms.ComboBox();
            this.cmbsophong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenmonhoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPM = new System.Windows.Forms.ListView();
            this.sophong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaovienday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtgiaovien
            // 
            this.txtgiaovien.Location = new System.Drawing.Point(266, 266);
            this.txtgiaovien.Name = "txtgiaovien";
            this.txtgiaovien.Size = new System.Drawing.Size(262, 33);
            this.txtgiaovien.TabIndex = 17;
            // 
            // buoiTH
            // 
            this.buoiTH.Text = "Buổi TH";
            this.buoiTH.Width = 103;
            // 
            // ngayTH
            // 
            this.ngayTH.Text = "Ngày TH";
            this.ngayTH.Width = 135;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 33);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cmbbuoi
            // 
            this.cmbbuoi.FormattingEnabled = true;
            this.cmbbuoi.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cmbbuoi.Location = new System.Drawing.Point(266, 213);
            this.cmbbuoi.Name = "cmbbuoi";
            this.cmbbuoi.Size = new System.Drawing.Size(262, 33);
            this.cmbbuoi.TabIndex = 13;
            // 
            // cmbmonhoc
            // 
            this.cmbmonhoc.FormattingEnabled = true;
            this.cmbmonhoc.Location = new System.Drawing.Point(266, 117);
            this.cmbmonhoc.Name = "cmbmonhoc";
            this.cmbmonhoc.Size = new System.Drawing.Size(262, 33);
            this.cmbmonhoc.TabIndex = 14;
            this.cmbmonhoc.SelectedIndexChanged += new System.EventHandler(this.cmbmonhoc_SelectedIndexChanged);
            // 
            // cmbsophong
            // 
            this.cmbsophong.FormattingEnabled = true;
            this.cmbsophong.Location = new System.Drawing.Point(266, 68);
            this.cmbsophong.Name = "cmbsophong";
            this.cmbsophong.Size = new System.Drawing.Size(262, 33);
            this.cmbsophong.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giáo viên dạy thực hành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buổi thực hành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày thực hành:";
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.Text = "Tên môn học";
            this.tenmonhoc.Width = 236;
            // 
            // listViewPM
            // 
            this.listViewPM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sophong,
            this.tenmonhoc,
            this.ngayTH,
            this.buoiTH,
            this.giaovienday});
            this.listViewPM.FullRowSelect = true;
            this.listViewPM.Location = new System.Drawing.Point(57, 409);
            this.listViewPM.MultiSelect = false;
            this.listViewPM.Name = "listViewPM";
            this.listViewPM.Size = new System.Drawing.Size(771, 310);
            this.listViewPM.TabIndex = 22;
            this.listViewPM.TabStop = false;
            this.listViewPM.UseCompatibleStateImageBehavior = false;
            this.listViewPM.View = System.Windows.Forms.View.Details;
            this.listViewPM.Click += new System.EventHandler(this.listViewPM_Click);
            // 
            // sophong
            // 
            this.sophong.Text = "Số phòng";
            this.sophong.Width = 100;
            // 
            // giaovienday
            // 
            this.giaovienday.Text = "Giáo viên dạy";
            this.giaovienday.Width = 199;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(514, 317);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 33);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(338, 317);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 33);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa đổi";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(160, 317);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 33);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(557, 68);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(303, 33);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In lịch thực hành phòng máy";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "LỊCH HỌC PHÒNG MÁY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "PHÂN BỐ PHÒNG THỰC HÀNH";
            // 
            // FormQLPTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 741);
            this.Controls.Add(this.txtgiaovien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbbuoi);
            this.Controls.Add(this.cmbmonhoc);
            this.Controls.Add(this.cmbsophong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewPM);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQLPTH";
            this.Text = "Quản lý phòng thực hành";
            this.Load += new System.EventHandler(this.FormQLPTH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgiaovien;
        private System.Windows.Forms.ColumnHeader buoiTH;
        private System.Windows.Forms.ColumnHeader ngayTH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbbuoi;
        private System.Windows.Forms.ComboBox cmbmonhoc;
        private System.Windows.Forms.ComboBox cmbsophong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader tenmonhoc;
        private System.Windows.Forms.ListView listViewPM;
        private System.Windows.Forms.ColumnHeader sophong;
        private System.Windows.Forms.ColumnHeader giaovienday;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

