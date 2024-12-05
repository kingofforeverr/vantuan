namespace WinFormsApp2
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            tínhToánToolStripMenuItem = new ToolStripMenuItem();
            máyTínhToolStripMenuItem = new ToolStripMenuItem();
            quảnLýPhòngTrọToolStripMenuItem = new ToolStripMenuItem();
            quảnLýDịchVụToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýKháchHàngToolStripMenuItem, tínhToánToolStripMenuItem, quảnLýPhòngTrọToolStripMenuItem, quảnLýDịchVụToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem });
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(152, 24);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(224, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // tínhToánToolStripMenuItem
            // 
            tínhToánToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { máyTínhToolStripMenuItem });
            tínhToánToolStripMenuItem.Name = "tínhToánToolStripMenuItem";
            tínhToánToolStripMenuItem.Size = new Size(142, 24);
            tínhToánToolStripMenuItem.Text = "Quản lý hợp đồng";
            // 
            // máyTínhToolStripMenuItem
            // 
            máyTínhToolStripMenuItem.Name = "máyTínhToolStripMenuItem";
            máyTínhToolStripMenuItem.Size = new Size(224, 26);
            máyTínhToolStripMenuItem.Text = "Máy tính";
            máyTínhToolStripMenuItem.Click += máyTínhToolStripMenuItem_Click;
            // 
            // quảnLýPhòngTrọToolStripMenuItem
            // 
            quảnLýPhòngTrọToolStripMenuItem.Name = "quảnLýPhòngTrọToolStripMenuItem";
            quảnLýPhòngTrọToolStripMenuItem.Size = new Size(143, 24);
            quảnLýPhòngTrọToolStripMenuItem.Text = "Quản lý phòng trọ";
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            quảnLýDịchVụToolStripMenuItem.Size = new Size(124, 24);
            quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(132, 24);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 530);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem tínhToánToolStripMenuItem;
        private ToolStripMenuItem máyTínhToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhòngTrọToolStripMenuItem;
        private ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
    }
}