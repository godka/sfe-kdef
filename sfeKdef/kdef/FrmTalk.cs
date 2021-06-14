using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sfeGlobal;
namespace sfeKdef.kdef
{
    public partial class FrmTalk : Form
    {
        public List<string> strtalk;
        //private int splitnumber = 12;
        public FrmTalk()
        {
            InitializeComponent();
            strtalk = Global.Talk;
            this.List1.txt2rini += new EventHandler(setValue);
            for (int i = 0; i < strtalk.Count; i++)
            {
                ListViewItem lst = new ListViewItem(i.ToString());
                lst.SubItems.Add(strtalk[i].Replace("*", ""));
                List1.Items.Add(lst);
            }
            //排序
            List1.sortlist();

        }
        void setValue(object sender, EventArgs e)
        {
            if (List1.SelectedItems.Count != 0)
            {
                int index = List1.SelectedItems[0].Index;
                int splitnum = 12;
                int.TryParse(toolStripComboBox1.Text,out splitnum);
                strtalk[index] = Global.Talk_split(List1.SelectedItems[0].SubItems[1].Text,splitnum,"*");
            }
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void 新增对话ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem newlist = new ListViewItem(strtalk.Count.ToString());
            strtalk.Add("新增对话");
            newlist.SubItems.Add("双击创建新对话");
            List1.Items.Add(newlist);
            List1.Items[strtalk.Count-1].Selected = true;
            List1.Items[strtalk.Count - 1].Focused = true;
            //List1.SelectedItems[0].Index = 0;
        }

        private void 删除当前对话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strtalk.RemoveAt(strtalk.Count - 1);
            List1.Items.RemoveAt(strtalk.Count);
        }

        private void 保存对话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //每隔12个字分行
            //string split = sfeadd.Str.InputBox("请输入分割字符串分割数，默认为12", "确认", "12");
            //for(int i =0;
           
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
}
