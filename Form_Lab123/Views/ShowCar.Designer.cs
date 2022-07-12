namespace Form_Lab123.Views
{
    partial class ShowCar
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
            this.cb_hienthi = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_showCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCart)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_hienthi
            // 
            this.cb_hienthi.AutoSize = true;
            this.cb_hienthi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_hienthi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_hienthi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cb_hienthi.Location = new System.Drawing.Point(105, 83);
            this.cb_hienthi.Name = "cb_hienthi";
            this.cb_hienthi.Size = new System.Drawing.Size(178, 24);
            this.cb_hienthi.TabIndex = 0;
            this.cb_hienthi.Text = "Hiện thị danh sách xe";
            this.cb_hienthi.UseVisualStyleBackColor = false;
            this.cb_hienthi.CheckedChanged += new System.EventHandler(this.cb_hienthi_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(576, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm xe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_showCart
            // 
            this.dgv_showCart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_showCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showCart.Location = new System.Drawing.Point(12, 168);
            this.dgv_showCart.Name = "dgv_showCart";
            this.dgv_showCart.RowHeadersWidth = 51;
            this.dgv_showCart.RowTemplate.Height = 29;
            this.dgv_showCart.Size = new System.Drawing.Size(776, 270);
            this.dgv_showCart.TabIndex = 2;
            // 
            // ShowCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_showCart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_hienthi);
            this.Name = "ShowCar";
            this.Text = "ShowCar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_hienthi;
        private Button button1;
        private DataGridView dgv_showCart;
    }
}