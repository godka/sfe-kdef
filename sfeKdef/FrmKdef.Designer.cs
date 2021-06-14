namespace sfeKdef
{
    partial class FrmKdef
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
            this.comboList = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存所有对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存所有指令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用强制读取模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用强制读取模式ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭强制读取模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开对话编辑器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存所有对话ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.导出luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出所有剧本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出当前剧本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboList
            // 
            this.comboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboList.FormattingEnabled = true;
            this.comboList.Location = new System.Drawing.Point(12, 31);
            this.comboList.Name = "comboList";
            this.comboList.Size = new System.Drawing.Size(97, 486);
            this.comboList.TabIndex = 3;
            this.comboList.SelectedIndexChanged += new System.EventHandler(this.comboList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.对话ToolStripMenuItem,
            this.导出luaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存所有对话ToolStripMenuItem,
            this.保存所有指令ToolStripMenuItem,
            this.启用强制读取模式ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存所有对话ToolStripMenuItem
            // 
            this.保存所有对话ToolStripMenuItem.Name = "保存所有对话ToolStripMenuItem";
            this.保存所有对话ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.保存所有对话ToolStripMenuItem.Text = "保存所有对话";
            this.保存所有对话ToolStripMenuItem.Click += new System.EventHandler(this.保存所有对话ToolStripMenuItem_Click);
            // 
            // 保存所有指令ToolStripMenuItem
            // 
            this.保存所有指令ToolStripMenuItem.Name = "保存所有指令ToolStripMenuItem";
            this.保存所有指令ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.保存所有指令ToolStripMenuItem.Text = "保存所有指令";
            this.保存所有指令ToolStripMenuItem.Click += new System.EventHandler(this.保存所有指令ToolStripMenuItem_Click);
            // 
            // 启用强制读取模式ToolStripMenuItem
            // 
            this.启用强制读取模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启用强制读取模式ToolStripMenuItem1,
            this.关闭强制读取模式ToolStripMenuItem});
            this.启用强制读取模式ToolStripMenuItem.Name = "启用强制读取模式ToolStripMenuItem";
            this.启用强制读取模式ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.启用强制读取模式ToolStripMenuItem.Text = "强制读取模式";
            // 
            // 启用强制读取模式ToolStripMenuItem1
            // 
            this.启用强制读取模式ToolStripMenuItem1.Name = "启用强制读取模式ToolStripMenuItem1";
            this.启用强制读取模式ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.启用强制读取模式ToolStripMenuItem1.Text = "启用强制读取模式";
            // 
            // 关闭强制读取模式ToolStripMenuItem
            // 
            this.关闭强制读取模式ToolStripMenuItem.Name = "关闭强制读取模式ToolStripMenuItem";
            this.关闭强制读取模式ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.关闭强制读取模式ToolStripMenuItem.Text = "关闭强制读取模式";
            // 
            // 对话ToolStripMenuItem
            // 
            this.对话ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开对话编辑器ToolStripMenuItem,
            this.保存所有对话ToolStripMenuItem1});
            this.对话ToolStripMenuItem.Name = "对话ToolStripMenuItem";
            this.对话ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.对话ToolStripMenuItem.Text = "对话";
            // 
            // 打开对话编辑器ToolStripMenuItem
            // 
            this.打开对话编辑器ToolStripMenuItem.Name = "打开对话编辑器ToolStripMenuItem";
            this.打开对话编辑器ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.打开对话编辑器ToolStripMenuItem.Text = "打开对话编辑器";
            this.打开对话编辑器ToolStripMenuItem.Click += new System.EventHandler(this.打开对话编辑器ToolStripMenuItem_Click);
            // 
            // 保存所有对话ToolStripMenuItem1
            // 
            this.保存所有对话ToolStripMenuItem1.Name = "保存所有对话ToolStripMenuItem1";
            this.保存所有对话ToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.保存所有对话ToolStripMenuItem1.Text = "保存所有对话";
            this.保存所有对话ToolStripMenuItem1.Click += new System.EventHandler(this.保存所有对话ToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1029, 451);
            this.textBox1.TabIndex = 6;
            // 
            // 导出luaToolStripMenuItem
            // 
            this.导出luaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出所有剧本ToolStripMenuItem,
            this.导出当前剧本ToolStripMenuItem});
            this.导出luaToolStripMenuItem.Name = "导出luaToolStripMenuItem";
            this.导出luaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.导出luaToolStripMenuItem.Text = "导出lua";
            // 
            // 导出所有剧本ToolStripMenuItem
            // 
            this.导出所有剧本ToolStripMenuItem.Name = "导出所有剧本ToolStripMenuItem";
            this.导出所有剧本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出所有剧本ToolStripMenuItem.Text = "导出所有剧本";
            this.导出所有剧本ToolStripMenuItem.Click += new System.EventHandler(this.导出所有剧本ToolStripMenuItem_Click);
            // 
            // 导出当前剧本ToolStripMenuItem
            // 
            this.导出当前剧本ToolStripMenuItem.Name = "导出当前剧本ToolStripMenuItem";
            this.导出当前剧本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出当前剧本ToolStripMenuItem.Text = "导出当前剧本";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(115, 489);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1029, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // FrmKdef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 514);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmKdef";
            this.Text = "sfe#-KdefEdit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存所有对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存所有指令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用强制读取模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用强制读取模式ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关闭强制读取模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开对话编辑器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存所有对话ToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 导出luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出所有剧本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出当前剧本ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

