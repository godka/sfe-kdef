namespace sfeKdef.kdef
{
    partial class FrmTalk
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
            this.components = new System.ComponentModel.Container();
            this.List1 = new sfeadd.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.新增对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入导出对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除当前对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List1
            // 
            this.List1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.List1.ContextMenuStrip = this.contextMenuStrip1;
            this.List1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List1.FullRowSelect = true;
            this.List1.GridLines = true;
            this.List1.Location = new System.Drawing.Point(0, 0);
            this.List1.MultiSelect = false;
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(780, 584);
            this.List1.TabIndex = 0;
            this.List1.UseCompatibleStateImageBehavior = false;
            this.List1.View = System.Windows.Forms.View.Details;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "对话";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.新增对话ToolStripMenuItem,
            this.导入导出对话ToolStripMenuItem,
            this.删除当前对话ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 136);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem1.Text = "设置分割字数";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "12",
            "24",
            "48",
            "96"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Text = "12";
            // 
            // 新增对话ToolStripMenuItem
            // 
            this.新增对话ToolStripMenuItem.Name = "新增对话ToolStripMenuItem";
            this.新增对话ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.新增对话ToolStripMenuItem.Text = "新增对话";
            this.新增对话ToolStripMenuItem.Click += new System.EventHandler(this.新增对话ToolStripMenuItem1_Click);
            // 
            // 导入导出对话ToolStripMenuItem
            // 
            this.导入导出对话ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入对话ToolStripMenuItem,
            this.导出对话ToolStripMenuItem});
            this.导入导出对话ToolStripMenuItem.Name = "导入导出对话ToolStripMenuItem";
            this.导入导出对话ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.导入导出对话ToolStripMenuItem.Text = "导入/导出对话";
            // 
            // 导入对话ToolStripMenuItem
            // 
            this.导入对话ToolStripMenuItem.Name = "导入对话ToolStripMenuItem";
            this.导入对话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入对话ToolStripMenuItem.Text = "导入对话";
            // 
            // 导出对话ToolStripMenuItem
            // 
            this.导出对话ToolStripMenuItem.Name = "导出对话ToolStripMenuItem";
            this.导出对话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出对话ToolStripMenuItem.Text = "导出对话";
            // 
            // 删除当前对话ToolStripMenuItem
            // 
            this.删除当前对话ToolStripMenuItem.Name = "删除当前对话ToolStripMenuItem";
            this.删除当前对话ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除当前对话ToolStripMenuItem.Text = "删除最后一条对话";
            this.删除当前对话ToolStripMenuItem.Click += new System.EventHandler(this.删除当前对话ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // FrmTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 584);
            this.Controls.Add(this.List1);
            this.Name = "FrmTalk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sfe#-talk";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private sfeadd.ListViewEx List1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入导出对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;



    }
}