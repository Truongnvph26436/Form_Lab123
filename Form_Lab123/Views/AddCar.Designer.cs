namespace Form_Lab123.Views
{
    partial class AddCar
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
            this.tb_tenXe = new System.Windows.Forms.TextBox();
            this.cbp_hangXe = new System.Windows.Forms.ComboBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_soLuong = new System.Windows.Forms.TextBox();
            this.bt_addXe = new System.Windows.Forms.Button();
            this.lb_loiten = new System.Windows.Forms.Label();
            this.lb_loihang = new System.Windows.Forms.Label();
            this.lb_loigia = new System.Windows.Forms.Label();
            this.lb_loisluong = new System.Windows.Forms.Label();
            this.lb_checkgia = new System.Windows.Forms.Label();
            this.lb_checksoluong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá cả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // tb_tenXe
            // 
            this.tb_tenXe.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenXe.Location = new System.Drawing.Point(200, 51);
            this.tb_tenXe.Name = "tb_tenXe";
            this.tb_tenXe.Size = new System.Drawing.Size(297, 26);
            this.tb_tenXe.TabIndex = 4;
            // 
            // cbp_hangXe
            // 
            this.cbp_hangXe.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbp_hangXe.FormattingEnabled = true;
            this.cbp_hangXe.Items.AddRange(new object[] {
            "Toyota",
            "Huyndai",
            "Honda",
            "Mercedes",
            "BMW"});
            this.cbp_hangXe.Location = new System.Drawing.Point(200, 122);
            this.cbp_hangXe.Name = "cbp_hangXe";
            this.cbp_hangXe.Size = new System.Drawing.Size(297, 26);
            this.cbp_hangXe.TabIndex = 5;
            this.cbp_hangXe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbp_hangXe_KeyDown);
            // 
            // tb_gia
            // 
            this.tb_gia.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_gia.Location = new System.Drawing.Point(200, 200);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(297, 26);
            this.tb_gia.TabIndex = 6;
            this.tb_gia.TextChanged += new System.EventHandler(this.tb_gia_TextChanged);
            // 
            // tb_soLuong
            // 
            this.tb_soLuong.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_soLuong.Location = new System.Drawing.Point(200, 270);
            this.tb_soLuong.Name = "tb_soLuong";
            this.tb_soLuong.Size = new System.Drawing.Size(297, 26);
            this.tb_soLuong.TabIndex = 7;
            this.tb_soLuong.TextChanged += new System.EventHandler(this.tb_soLuong_TextChanged);
            // 
            // bt_addXe
            // 
            this.bt_addXe.BackColor = System.Drawing.SystemColors.Info;
            this.bt_addXe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_addXe.ForeColor = System.Drawing.Color.Black;
            this.bt_addXe.Location = new System.Drawing.Point(253, 337);
            this.bt_addXe.Name = "bt_addXe";
            this.bt_addXe.Size = new System.Drawing.Size(138, 38);
            this.bt_addXe.TabIndex = 8;
            this.bt_addXe.Text = "Nhập xe";
            this.bt_addXe.UseVisualStyleBackColor = false;
            this.bt_addXe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_loiten
            // 
            this.lb_loiten.AutoSize = true;
            this.lb_loiten.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loiten.ForeColor = System.Drawing.Color.Red;
            this.lb_loiten.Location = new System.Drawing.Point(209, 78);
            this.lb_loiten.Name = "lb_loiten";
            this.lb_loiten.Size = new System.Drawing.Size(135, 18);
            this.lb_loiten.TabIndex = 9;
            this.lb_loiten.Text = "Vui lòng nhập tên xe";
            // 
            // lb_loihang
            // 
            this.lb_loihang.AutoSize = true;
            this.lb_loihang.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loihang.ForeColor = System.Drawing.Color.Red;
            this.lb_loihang.Location = new System.Drawing.Point(209, 150);
            this.lb_loihang.Name = "lb_loihang";
            this.lb_loihang.Size = new System.Drawing.Size(184, 18);
            this.lb_loihang.TabIndex = 10;
            this.lb_loihang.Text = "Vui lòng chọn hãng sản xuất";
            // 
            // lb_loigia
            // 
            this.lb_loigia.AutoSize = true;
            this.lb_loigia.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loigia.ForeColor = System.Drawing.Color.Red;
            this.lb_loigia.Location = new System.Drawing.Point(209, 227);
            this.lb_loigia.Name = "lb_loigia";
            this.lb_loigia.Size = new System.Drawing.Size(135, 18);
            this.lb_loigia.TabIndex = 11;
            this.lb_loigia.Text = "Vui lòng nhập giá cả";
            // 
            // lb_loisluong
            // 
            this.lb_loisluong.AutoSize = true;
            this.lb_loisluong.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_loisluong.ForeColor = System.Drawing.Color.Red;
            this.lb_loisluong.Location = new System.Drawing.Point(209, 297);
            this.lb_loisluong.Name = "lb_loisluong";
            this.lb_loisluong.Size = new System.Drawing.Size(153, 18);
            this.lb_loisluong.TabIndex = 12;
            this.lb_loisluong.Text = "Vui lòng nhập số lượng";
            // 
            // lb_checkgia
            // 
            this.lb_checkgia.AutoSize = true;
            this.lb_checkgia.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_checkgia.ForeColor = System.Drawing.Color.Red;
            this.lb_checkgia.Location = new System.Drawing.Point(209, 227);
            this.lb_checkgia.Name = "lb_checkgia";
            this.lb_checkgia.Size = new System.Drawing.Size(114, 18);
            this.lb_checkgia.TabIndex = 13;
            this.lb_checkgia.Text = "Giá không hợp lệ";
            // 
            // lb_checksoluong
            // 
            this.lb_checksoluong.AutoSize = true;
            this.lb_checksoluong.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_checksoluong.ForeColor = System.Drawing.Color.Red;
            this.lb_checksoluong.Location = new System.Drawing.Point(209, 299);
            this.lb_checksoluong.Name = "lb_checksoluong";
            this.lb_checksoluong.Size = new System.Drawing.Size(148, 18);
            this.lb_checksoluong.TabIndex = 14;
            this.lb_checksoluong.Text = "Số lượng không hợp lệ";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 405);
            this.Controls.Add(this.lb_checksoluong);
            this.Controls.Add(this.lb_checkgia);
            this.Controls.Add(this.lb_loisluong);
            this.Controls.Add(this.lb_loigia);
            this.Controls.Add(this.lb_loihang);
            this.Controls.Add(this.lb_loiten);
            this.Controls.Add(this.bt_addXe);
            this.Controls.Add(this.tb_soLuong);
            this.Controls.Add(this.tb_gia);
            this.Controls.Add(this.cbp_hangXe);
            this.Controls.Add(this.tb_tenXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_tenXe;
        private ComboBox cbp_hangXe;
        private TextBox tb_gia;
        private TextBox tb_soLuong;
        private Button bt_addXe;
        private Label lb_loiten;
        private Label lb_loihang;
        private Label lb_loigia;
        private Label lb_loisluong;
        private Label lb_checkgia;
        private Label lb_checksoluong;
    }
}