namespace Buoi3_bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkNho = new CheckBox();
            btnDangnhap = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 113);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 145);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(199, 106);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(148, 26);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(199, 138);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(148, 26);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(106, 167);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(75, 23);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            chkNho.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(106, 196);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(87, 28);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(199, 196);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 28);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button2_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(275, 196);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(72, 28);
            btnDung.TabIndex = 7;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnDangnhap);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkNho;
        private Button btnDangnhap;
        private Button btnXoa;
        private Button btnDung;
    }
}
