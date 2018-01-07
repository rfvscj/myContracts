namespace myContracts
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机应用");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("信息安全");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("电子信息科学");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("网络工程");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_add,
            this.toolStrip_edit,
            this.toolStrip_delete,
            this.toolStrip_search,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1137, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStrip_add
            // 
            this.toolStrip_add.AutoSize = false;
            this.toolStrip_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_add.Image")));
            this.toolStrip_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_add.Name = "toolStrip_add";
            this.toolStrip_add.Size = new System.Drawing.Size(70, 50);
            this.toolStrip_add.Text = "添加";
            this.toolStrip_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_add.Click += new System.EventHandler(this.toolStrip_add_Click);
            // 
            // toolStrip_edit
            // 
            this.toolStrip_edit.AutoSize = false;
            this.toolStrip_edit.BackColor = System.Drawing.Color.Silver;
            this.toolStrip_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_edit.Image")));
            this.toolStrip_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_edit.Name = "toolStrip_edit";
            this.toolStrip_edit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStrip_edit.Size = new System.Drawing.Size(70, 50);
            this.toolStrip_edit.Text = "编辑";
            this.toolStrip_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_edit.Click += new System.EventHandler(this.toolStrip_edit_Click);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.AutoSize = false;
            this.toolStrip_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_delete.Image")));
            this.toolStrip_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(70, 50);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.AutoSize = false;
            this.toolStrip_search.BackColor = System.Drawing.Color.Silver;
            this.toolStrip_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_search.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_search.Image")));
            this.toolStrip_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(70, 50);
            this.toolStrip_search.Text = "查找";
            this.toolStrip_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStrip_search.Click += new System.EventHandler(this.toolStrip_search_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 50);
            this.toolStripButton1.Text = "备份";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.Silver;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 50);
            this.toolStripButton2.Text = "恢复";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 498);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "计算机应用";
            treeNode1.Tag = "1";
            treeNode1.Text = "计算机应用";
            treeNode2.Name = "信息安全";
            treeNode2.Tag = "1";
            treeNode2.Text = "信息安全";
            treeNode3.Name = "电子信息科学";
            treeNode3.Tag = "1";
            treeNode3.Text = "电子信息科学";
            treeNode4.Name = "网络工程";
            treeNode4.Tag = "1";
            treeNode4.Text = "网络工程";
            treeNode5.Name = "全部";
            treeNode5.Tag = "0";
            treeNode5.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(215, 463);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(915, 498);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1137, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myContracts";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_edit;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripButton toolStrip_search;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStrip_add;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

