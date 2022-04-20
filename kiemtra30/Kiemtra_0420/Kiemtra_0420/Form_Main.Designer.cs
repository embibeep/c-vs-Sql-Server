namespace Kiemtra_0420
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
            this.btn_Bai1 = new System.Windows.Forms.Button();
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy lựa chọn bài tập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Bai1
            // 
            this.btn_Bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai1.Location = new System.Drawing.Point(224, 108);
            this.btn_Bai1.Name = "btn_Bai1";
            this.btn_Bai1.Size = new System.Drawing.Size(127, 49);
            this.btn_Bai1.TabIndex = 1;
            this.btn_Bai1.Text = "Bài 1";
            this.btn_Bai1.UseVisualStyleBackColor = true;
            this.btn_Bai1.Click += new System.EventHandler(this.btn_Bai1_Click);
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai2.Location = new System.Drawing.Point(224, 182);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(127, 49);
            this.btn_Bai2.TabIndex = 2;
            this.btn_Bai2.Text = "Bài 2";
            this.btn_Bai2.UseVisualStyleBackColor = true;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(224, 253);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(127, 49);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Bai2);
            this.Controls.Add(this.btn_Bai1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bai1;
        private System.Windows.Forms.Button btn_Bai2;
        private System.Windows.Forms.Button btn_Exit;
    }
}

