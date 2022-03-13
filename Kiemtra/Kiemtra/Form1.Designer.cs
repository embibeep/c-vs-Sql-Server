namespace Kiemtra
{
    partial class Form1
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
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rdwin = new System.Windows.Forms.RadioButton();
            this.rdsql = new System.Windows.Forms.RadioButton();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSave_String = new System.Windows.Forms.Button();
            this.btnRead_String = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(329, 388);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(147, 53);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.Location = new System.Drawing.Point(23, 388);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(147, 53);
            this.btnAccess.TabIndex = 5;
            this.btnAccess.Text = "Access";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên Máy Chủ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(636, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(176, 388);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 53);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rdwin
            // 
            this.rdwin.AutoSize = true;
            this.rdwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdwin.Location = new System.Drawing.Point(279, 170);
            this.rdwin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdwin.Name = "rdwin";
            this.rdwin.Size = new System.Drawing.Size(292, 29);
            this.rdwin.TabIndex = 24;
            this.rdwin.Text = "Chứng thực bằng Windows\r\n";
            this.rdwin.UseVisualStyleBackColor = true;
            this.rdwin.CheckedChanged += new System.EventHandler(this.rdwin_CheckedChanged);
            // 
            // rdsql
            // 
            this.rdsql.AutoSize = true;
            this.rdsql.Checked = true;
            this.rdsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsql.Location = new System.Drawing.Point(279, 204);
            this.rdsql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdsql.Name = "rdsql";
            this.rdsql.Size = new System.Drawing.Size(248, 29);
            this.rdsql.TabIndex = 23;
            this.rdsql.TabStop = true;
            this.rdsql.Text = "Chứng thực bằng SQL";
            this.rdsql.UseVisualStyleBackColor = true;
            this.rdsql.CheckedChanged += new System.EventHandler(this.rdsql_CheckedChanged);
            // 
            // txtdatabase
            // 
            this.txtdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabase.Location = new System.Drawing.Point(268, 114);
            this.txtdatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(513, 38);
            this.txtdatabase.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(268, 309);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(513, 38);
            this.txtpass.TabIndex = 4;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(268, 256);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(513, 38);
            this.txtuser.TabIndex = 3;
            // 
            // txtserver
            // 
            this.txtserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.Location = new System.Drawing.Point(268, 62);
            this.txtserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(513, 38);
            this.txtserver.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Database";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 49);
            this.label1.TabIndex = 30;
            this.label1.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(483, 388);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(147, 53);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSave_String
            // 
            this.btnSave_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_String.Location = new System.Drawing.Point(23, 456);
            this.btnSave_String.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave_String.Name = "btnSave_String";
            this.btnSave_String.Size = new System.Drawing.Size(147, 53);
            this.btnSave_String.TabIndex = 10;
            this.btnSave_String.Text = "Save";
            this.btnSave_String.UseVisualStyleBackColor = true;
            this.btnSave_String.Click += new System.EventHandler(this.btnSave_String_Click);
            // 
            // btnRead_String
            // 
            this.btnRead_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead_String.Location = new System.Drawing.Point(176, 456);
            this.btnRead_String.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead_String.Name = "btnRead_String";
            this.btnRead_String.Size = new System.Drawing.Size(147, 53);
            this.btnRead_String.TabIndex = 11;
            this.btnRead_String.Text = "Read";
            this.btnRead_String.UseVisualStyleBackColor = true;
            this.btnRead_String.Click += new System.EventHandler(this.btnRead_String_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btnRead_String);
            this.Controls.Add(this.btnSave_String);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rdwin);
            this.Controls.Add(this.rdsql);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rdwin;
        private System.Windows.Forms.RadioButton rdsql;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSave_String;
        private System.Windows.Forms.Button btnRead_String;
    }
}

