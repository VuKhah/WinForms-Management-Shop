namespace WinForms_Management_Shop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_lb = new System.Windows.Forms.Label();
            this.statistical_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add_bt = new System.Windows.Forms.Button();
            this.Delete_bt = new System.Windows.Forms.Button();
            this.Save_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Search_lb);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Search_lb
            // 
            this.Search_lb.AutoSize = true;
            this.Search_lb.Location = new System.Drawing.Point(19, 22);
            this.Search_lb.Name = "Search_lb";
            this.Search_lb.Size = new System.Drawing.Size(91, 22);
            this.Search_lb.TabIndex = 0;
            this.Search_lb.Text = "Tìm kiếm:";
            // 
            // statistical_bt
            // 
            this.statistical_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statistical_bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.statistical_bt.FlatAppearance.BorderSize = 5;
            this.statistical_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.statistical_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.statistical_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statistical_bt.Location = new System.Drawing.Point(156, 14);
            this.statistical_bt.Name = "statistical_bt";
            this.statistical_bt.Size = new System.Drawing.Size(166, 37);
            this.statistical_bt.TabIndex = 1;
            this.statistical_bt.Text = "Thống kê";
            this.statistical_bt.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(23, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 398);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statistical_bt);
            this.panel3.Controls.Add(this.Add_bt);
            this.panel3.Controls.Add(this.Delete_bt);
            this.panel3.Controls.Add(this.Save_bt);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(23, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 67);
            this.panel3.TabIndex = 2;
            // 
            // Add_bt
            // 
            this.Add_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_bt.FlatAppearance.BorderSize = 5;
            this.Add_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Add_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_bt.Location = new System.Drawing.Point(347, 14);
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.Size = new System.Drawing.Size(166, 37);
            this.Add_bt.TabIndex = 4;
            this.Add_bt.Text = "Thêm";
            this.Add_bt.UseVisualStyleBackColor = false;
            this.Add_bt.Click += new System.EventHandler(this.Add_bt_Click);
            // 
            // Delete_bt
            // 
            this.Delete_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete_bt.FlatAppearance.BorderSize = 5;
            this.Delete_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Delete_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Delete_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_bt.Location = new System.Drawing.Point(538, 14);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(166, 37);
            this.Delete_bt.TabIndex = 3;
            this.Delete_bt.Text = "Xóa";
            this.Delete_bt.UseVisualStyleBackColor = false;
            // 
            // Save_bt
            // 
            this.Save_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_bt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_bt.FlatAppearance.BorderSize = 5;
            this.Save_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Save_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_bt.Location = new System.Drawing.Point(732, 14);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(166, 37);
            this.Save_bt.TabIndex = 2;
            this.Save_bt.Text = "Lưu";
            this.Save_bt.UseVisualStyleBackColor = false;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Main";
            this.Text = "Management ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Search_lb;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button statistical_bt;
        public System.Windows.Forms.Button Add_bt;
        public System.Windows.Forms.Button Delete_bt;
        public System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

