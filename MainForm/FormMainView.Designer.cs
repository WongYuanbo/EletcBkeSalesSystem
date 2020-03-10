namespace EBike.MainForm
{
    partial class FormMainView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.单条件查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.组合查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按车辆属性入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单条件统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.组合统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按车辆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按条件删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存查询ToolStripMenuItem,
            this.库存查询ToolStripMenuItem1,
            this.销售入库ToolStripMenuItem,
            this.销售统计ToolStripMenuItem,
            this.车辆信息修改ToolStripMenuItem,
            this.车辆信息删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆入库ToolStripMenuItem,
            this.批入库ToolStripMenuItem});
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存查询ToolStripMenuItem.Text = "新车入库";
            // 
            // 车辆入库ToolStripMenuItem
            // 
            this.车辆入库ToolStripMenuItem.Name = "车辆入库ToolStripMenuItem";
            this.车辆入库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.车辆入库ToolStripMenuItem.Text = "车辆入库";
            this.车辆入库ToolStripMenuItem.Click += new System.EventHandler(this.车辆入库ToolStripMenuItem_Click_1);
            // 
            // 批入库ToolStripMenuItem
            // 
            this.批入库ToolStripMenuItem.Name = "批入库ToolStripMenuItem";
            this.批入库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.批入库ToolStripMenuItem.Text = "批量入库";
            // 
            // 库存查询ToolStripMenuItem1
            // 
            this.库存查询ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单条件查询ToolStripMenuItem,
            this.组合查询ToolStripMenuItem});
            this.库存查询ToolStripMenuItem1.Name = "库存查询ToolStripMenuItem1";
            this.库存查询ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.库存查询ToolStripMenuItem1.Text = "库存查询";
            // 
            // 单条件查询ToolStripMenuItem
            // 
            this.单条件查询ToolStripMenuItem.Name = "单条件查询ToolStripMenuItem";
            this.单条件查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.单条件查询ToolStripMenuItem.Text = "单条件查询";
            this.单条件查询ToolStripMenuItem.Click += new System.EventHandler(this.单条件查询ToolStripMenuItem_Click);
            // 
            // 组合查询ToolStripMenuItem
            // 
            this.组合查询ToolStripMenuItem.Name = "组合查询ToolStripMenuItem";
            this.组合查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.组合查询ToolStripMenuItem.Text = "组合查询";
            // 
            // 销售入库ToolStripMenuItem
            // 
            this.销售入库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按车辆属性入库ToolStripMenuItem});
            this.销售入库ToolStripMenuItem.Name = "销售入库ToolStripMenuItem";
            this.销售入库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售入库ToolStripMenuItem.Text = "销售入库";
            // 
            // 按车辆属性入库ToolStripMenuItem
            // 
            this.按车辆属性入库ToolStripMenuItem.Name = "按车辆属性入库ToolStripMenuItem";
            this.按车辆属性入库ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.按车辆属性入库ToolStripMenuItem.Text = "按车辆属性入库";
            this.按车辆属性入库ToolStripMenuItem.Click += new System.EventHandler(this.按车辆属性入库ToolStripMenuItem_Click_1);
            // 
            // 销售统计ToolStripMenuItem
            // 
            this.销售统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单条件统计ToolStripMenuItem,
            this.组合统计ToolStripMenuItem});
            this.销售统计ToolStripMenuItem.Name = "销售统计ToolStripMenuItem";
            this.销售统计ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售统计ToolStripMenuItem.Text = "销售统计";
            // 
            // 单条件统计ToolStripMenuItem
            // 
            this.单条件统计ToolStripMenuItem.Name = "单条件统计ToolStripMenuItem";
            this.单条件统计ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.单条件统计ToolStripMenuItem.Text = "单条件统计";
            this.单条件统计ToolStripMenuItem.Click += new System.EventHandler(this.单条件统计ToolStripMenuItem_Click);
            // 
            // 组合统计ToolStripMenuItem
            // 
            this.组合统计ToolStripMenuItem.Name = "组合统计ToolStripMenuItem";
            this.组合统计ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.组合统计ToolStripMenuItem.Text = "组合统计";
            // 
            // 车辆信息修改ToolStripMenuItem
            // 
            this.车辆信息修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按车辆ToolStripMenuItem});
            this.车辆信息修改ToolStripMenuItem.Name = "车辆信息修改ToolStripMenuItem";
            this.车辆信息修改ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.车辆信息修改ToolStripMenuItem.Text = "车辆信息修改";
            // 
            // 按车辆ToolStripMenuItem
            // 
            this.按车辆ToolStripMenuItem.Name = "按车辆ToolStripMenuItem";
            this.按车辆ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.按车辆ToolStripMenuItem.Text = "按车辆ID修改";
            this.按车辆ToolStripMenuItem.Click += new System.EventHandler(this.按车辆ToolStripMenuItem_Click);
            // 
            // 车辆信息删除ToolStripMenuItem
            // 
            this.车辆信息删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按条件删除ToolStripMenuItem});
            this.车辆信息删除ToolStripMenuItem.Name = "车辆信息删除ToolStripMenuItem";
            this.车辆信息删除ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.车辆信息删除ToolStripMenuItem.Text = "车辆信息删除";
            // 
            // 按条件删除ToolStripMenuItem
            // 
            this.按条件删除ToolStripMenuItem.Name = "按条件删除ToolStripMenuItem";
            this.按条件删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.按条件删除ToolStripMenuItem.Text = "按条件删除";
            this.按条件删除ToolStripMenuItem.Click += new System.EventHandler(this.按条件删除ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 412);
            this.panel1.TabIndex = 1;
            // 
            // FormMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainView";
            this.Text = "电动车销售管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 销售统计ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 单条件查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 组合查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单条件统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 组合统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按车辆属性入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按车辆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆信息删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按条件删除ToolStripMenuItem;
    }
}

