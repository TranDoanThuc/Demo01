namespace Nguyenthaison
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lưaChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênTôCungNhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyBênhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưaChonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lưaChonToolStripMenuItem
            // 
            this.lưaChonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyênTôCungNhauToolStripMenuItem,
            this.quanLyBênhNhânToolStripMenuItem});
            this.lưaChonToolStripMenuItem.Name = "lưaChonToolStripMenuItem";
            this.lưaChonToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.lưaChonToolStripMenuItem.Text = "&Lựa chọn";
            // 
            // nguyênTôCungNhauToolStripMenuItem
            // 
            this.nguyênTôCungNhauToolStripMenuItem.Name = "nguyênTôCungNhauToolStripMenuItem";
            this.nguyênTôCungNhauToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nguyênTôCungNhauToolStripMenuItem.Text = "&Nguyên tố cùng nhau";
            this.nguyênTôCungNhauToolStripMenuItem.Click += new System.EventHandler(this.nguyênTôCungNhauToolStripMenuItem_Click);
            // 
            // quanLyBênhNhânToolStripMenuItem
            // 
            this.quanLyBênhNhânToolStripMenuItem.Name = "quanLyBênhNhânToolStripMenuItem";
            this.quanLyBênhNhânToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quanLyBênhNhânToolStripMenuItem.Text = "&Quản lý bệnh nhân";
            this.quanLyBênhNhânToolStripMenuItem.Click += new System.EventHandler(this.quanLyBênhNhânToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nguyễn Thái Sơn 11/02/1999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nguyễn Thái Sơn 11/02/1999";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lưaChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênTôCungNhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyBênhNhânToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

