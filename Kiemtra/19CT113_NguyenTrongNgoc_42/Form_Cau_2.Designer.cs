namespace _19CT113_NguyenTrongNgoc_42
{
    partial class Form_Cau_2
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
            this.txt_MaCLB = new System.Windows.Forms.TextBox();
            this.txt_TenCLB = new System.Windows.Forms.TextBox();
            this.txt_SoDoi = new System.Windows.Forms.TextBox();
            this.dgv_Staff_2 = new System.Windows.Forms.DataGridView();
            this.btn_Edit_Dgv = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaCLB";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenCLB";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SoDoi";
            // 
            // txt_MaCLB
            // 
            this.txt_MaCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCLB.Location = new System.Drawing.Point(208, 10);
            this.txt_MaCLB.Name = "txt_MaCLB";
            this.txt_MaCLB.Size = new System.Drawing.Size(439, 22);
            this.txt_MaCLB.TabIndex = 3;
            // 
            // txt_TenCLB
            // 
            this.txt_TenCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenCLB.Location = new System.Drawing.Point(208, 49);
            this.txt_TenCLB.Name = "txt_TenCLB";
            this.txt_TenCLB.Size = new System.Drawing.Size(439, 22);
            this.txt_TenCLB.TabIndex = 4;
            // 
            // txt_SoDoi
            // 
            this.txt_SoDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDoi.Location = new System.Drawing.Point(208, 89);
            this.txt_SoDoi.Name = "txt_SoDoi";
            this.txt_SoDoi.Size = new System.Drawing.Size(439, 22);
            this.txt_SoDoi.TabIndex = 5;
            // 
            // dgv_Staff_2
            // 
            this.dgv_Staff_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff_2.Location = new System.Drawing.Point(13, 137);
            this.dgv_Staff_2.Name = "dgv_Staff_2";
            this.dgv_Staff_2.Size = new System.Drawing.Size(711, 316);
            this.dgv_Staff_2.TabIndex = 6;
            this.dgv_Staff_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_2_CellClick);
            // 
            // btn_Edit_Dgv
            // 
            this.btn_Edit_Dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Dgv.Location = new System.Drawing.Point(12, 468);
            this.btn_Edit_Dgv.Name = "btn_Edit_Dgv";
            this.btn_Edit_Dgv.Size = new System.Drawing.Size(97, 35);
            this.btn_Edit_Dgv.TabIndex = 7;
            this.btn_Edit_Dgv.Text = "Sửa Dgv";
            this.btn_Edit_Dgv.UseVisualStyleBackColor = true;
            this.btn_Edit_Dgv.Click += new System.EventHandler(this.btn_Edit_Dgv_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(165, 468);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 35);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(318, 468);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(97, 35);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(471, 468);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(97, 35);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(624, 468);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 35);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form_Cau_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 515);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Edit_Dgv);
            this.Controls.Add(this.dgv_Staff_2);
            this.Controls.Add(this.txt_SoDoi);
            this.Controls.Add(this.txt_TenCLB);
            this.Controls.Add(this.txt_MaCLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cau_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cau_2";
            this.Load += new System.EventHandler(this.Form_Cau_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaCLB;
        private System.Windows.Forms.TextBox txt_TenCLB;
        private System.Windows.Forms.TextBox txt_SoDoi;
        private System.Windows.Forms.DataGridView dgv_Staff_2;
        private System.Windows.Forms.Button btn_Edit_Dgv;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
    }
}