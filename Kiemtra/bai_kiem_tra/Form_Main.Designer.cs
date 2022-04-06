
namespace form_danh_sach
{
    partial class Form_Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.txt_DonViTinh = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoTon = new System.Windows.Forms.TextBox();
            this.txt_MaLH = new System.Windows.Forms.TextBox();
            this.txt_Loai = new System.Windows.Forms.TextBox();
            this.dgv_Staff = new System.Windows.Forms.DataGridView();
            this.btn_Edit_Dgv = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên MH";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã LH";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "ĐV Tính";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Tồn";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đơn Giá";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại";
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Location = new System.Drawing.Point(90, 11);
            this.txt_MaMH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(160, 20);
            this.txt_MaMH.TabIndex = 4;
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Location = new System.Drawing.Point(90, 52);
            this.txt_TenMH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(160, 20);
            this.txt_TenMH.TabIndex = 5;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Location = new System.Drawing.Point(88, 98);
            this.txt_DonViTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(160, 20);
            this.txt_DonViTinh.TabIndex = 6;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(344, 10);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(160, 20);
            this.txt_DonGia.TabIndex = 7;
            // 
            // txt_SoTon
            // 
            this.txt_SoTon.Location = new System.Drawing.Point(344, 52);
            this.txt_SoTon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoTon.Name = "txt_SoTon";
            this.txt_SoTon.Size = new System.Drawing.Size(160, 20);
            this.txt_SoTon.TabIndex = 8;
            // 
            // txt_MaLH
            // 
            this.txt_MaLH.Location = new System.Drawing.Point(344, 98);
            this.txt_MaLH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaLH.Name = "txt_MaLH";
            this.txt_MaLH.Size = new System.Drawing.Size(160, 20);
            this.txt_MaLH.TabIndex = 9;
            // 
            // txt_Loai
            // 
            this.txt_Loai.Location = new System.Drawing.Point(589, 9);
            this.txt_Loai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Loai.Name = "txt_Loai";
            this.txt_Loai.Size = new System.Drawing.Size(160, 20);
            this.txt_Loai.TabIndex = 10;
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff.Location = new System.Drawing.Point(13, 127);
            this.dgv_Staff.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.RowHeadersWidth = 51;
            this.dgv_Staff.RowTemplate.Height = 24;
            this.dgv_Staff.Size = new System.Drawing.Size(742, 284);
            this.dgv_Staff.TabIndex = 11;
            this.dgv_Staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_CellClick);
            // 
            // btn_Edit_Dgv
            // 
            this.btn_Edit_Dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Dgv.Location = new System.Drawing.Point(13, 436);
            this.btn_Edit_Dgv.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit_Dgv.Name = "btn_Edit_Dgv";
            this.btn_Edit_Dgv.Size = new System.Drawing.Size(87, 32);
            this.btn_Edit_Dgv.TabIndex = 12;
            this.btn_Edit_Dgv.Text = "Sửa dgv";
            this.btn_Edit_Dgv.UseVisualStyleBackColor = true;
            this.btn_Edit_Dgv.Click += new System.EventHandler(this.btn_Edit_Dgv_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(169, 436);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(87, 32);
            this.Btn_Update.TabIndex = 13;
            this.Btn_Update.Text = "Cập nhật";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(332, 436);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 32);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(510, 436);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 32);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(668, 436);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(87, 32);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.btn_Edit_Dgv);
            this.Controls.Add(this.dgv_Staff);
            this.Controls.Add(this.txt_Loai);
            this.Controls.Add(this.txt_MaLH);
            this.Controls.Add(this.txt_SoTon);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_DonViTinh);
            this.Controls.Add(this.txt_TenMH);
            this.Controls.Add(this.txt_MaMH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form danh sách";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.TextBox txt_DonViTinh;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoTon;
        private System.Windows.Forms.TextBox txt_MaLH;
        private System.Windows.Forms.TextBox txt_Loai;
        private System.Windows.Forms.DataGridView dgv_Staff;
        private System.Windows.Forms.Button btn_Edit_Dgv;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
    }
}

