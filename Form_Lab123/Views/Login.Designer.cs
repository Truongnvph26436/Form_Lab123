namespace Form_Lab123.Views
{
    partial class Login
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_loitk = new System.Windows.Forms.Label();
            this.lb_loimk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(276, 112);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(301, 27);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(276, 207);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(301, 27);
            this.tb_password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_loitk
            // 
            this.lb_loitk.AutoSize = true;
            this.lb_loitk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loitk.ForeColor = System.Drawing.Color.Red;
            this.lb_loitk.Location = new System.Drawing.Point(287, 151);
            this.lb_loitk.Name = "lb_loitk";
            this.lb_loitk.Size = new System.Drawing.Size(224, 20);
            this.lb_loitk.TabIndex = 5;
            this.lb_loitk.Text = "Tài khoản không được để trống";
            // 
            // lb_loimk
            // 
            this.lb_loimk.AutoSize = true;
            this.lb_loimk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loimk.ForeColor = System.Drawing.Color.Red;
            this.lb_loimk.Location = new System.Drawing.Point(287, 251);
            this.lb_loimk.Name = "lb_loimk";
            this.lb_loimk.Size = new System.Drawing.Size(222, 20);
            this.lb_loimk.TabIndex = 6;
            this.lb_loimk.Text = "Mật khẩu không được để trống";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_loimk);
            this.Controls.Add(this.lb_loitk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button button1;
        private Label lb_loitk;
        private Label lb_loimk;
    }
}