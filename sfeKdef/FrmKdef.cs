using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using sfeadd;
using sfeKdef.kdef;
namespace sfeKdef
{
    public partial class FrmKdef : Form
    {
        public JYkdef kdef;// = new JYkdef(jypath);
        public JYkdef.kdefeventclass kdefevent;
        public FrmKdef()
        {
            InitializeComponent(); 
            inital();
            for (int i = 0; i < kdef.KdefNum; i++)
            {
                comboList.Items.Add(i);
            }
        }

        private void inital()
        {

            JYpath jypath = new JYpath();
            jypath.FileTalkgrp = @".\data\talk1.grp";
            jypath.FileTalkIdx = @".\data\talk1.idx";
            jypath.FileKdefgrp = @".\data\Kdef.grp";
            jypath.FileKdefIdx = @".\data\Kdef.idx";
            kdef = new JYkdef(jypath);
            //add 2013年2月7日16:28:57
            //sfeGlobal.Global.LoadColor(jypath.FileCol);
            //sfeGlobal.Global.headRle = sfeGlobal.Global.LoadRlePic(jypath.FileHdIdx, jypath.FileHdgrp);
        }

        private void comboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kdefevent = kdef.RunBasic(this.comboList.SelectedIndex, this.List2);
            this.textBox1.Text = kdef.Run(this.comboList.SelectedIndex);
            //this.List2.sortlist();
        }

        private void 保存所有对话ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开对话编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTalk talk = new FrmTalk();
            talk.ShowDialog();
            sfeGlobal.Global.Talk = talk.strtalk;
        }

        private void 保存所有对话ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kdef.SaveTalk();
        }

        private void 保存所有指令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BC 7D AE 65 B1 A4 AA E1
            byte[] a = {0xbc,0x7d,0xae,0x65,0xb1,0xa4,0xaa,0xe1};
            MessageBox.Show(sfeadd.Str.Big5ToUnicode(a));
        }

        private void 导出所有剧本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@".\lua"))
                    Directory.CreateDirectory(@".\lua");
                string datestr = DateTime.Now.ToString("yyyyMMddhhmmss");
                Directory.CreateDirectory(string.Format(@".\lua\kaexport{0}", datestr));
                progressBar1.Maximum = kdef.KdefNum;
                for (int i = 0; i < kdef.KdefNum; i++)
                {
                    string strUnicode = kdef.Run(i);
                    byte[] strUTF8 = Encoding.UTF8.GetBytes(strUnicode);
                    FileStream fs = new FileStream(string.Format(@".\lua\kaexport{0}\ka{1}.lua", datestr, i), FileMode.Create);
                    fs.Write(strUTF8, 0, strUTF8.Length);
                    //StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    //sw.Write(strUnicode);
                    //sw.Close();
                    fs.Close();
                    progressBar1.Value = i;
                    Application.DoEvents();
                }
                MessageBox.Show("Done");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
            progressBar1.Value = 0;
        }

        //private void List2_Click(object sender, EventArgs e)
        //{
        //    ListEvent.Clear();
        //    if (List2.SelectedItems.Count != 0)
        //    {
        //        int realindex = getIndex();
        //        ListEvent.Columns.Add("参数0");
        //        ListViewItem tmpitem = new ListViewItem(kdefevent.kdefdata[realindex].labelkdef.Data[0].ToString());
        //        for (int i = 1; i < kdefevent.kdefdata[realindex].labelkdef.Data.Count; i++)
        //        {
        //            ListEvent.Columns.Add("参数" + i.ToString());
        //            tmpitem.SubItems.Add(kdefevent.kdefdata[realindex].labelkdef.Data[i].ToString());
        //        }
        //        ListEvent.Items.Add(tmpitem);
        //    }

        //}

        //private void List2_DoubleClick(object sender, EventArgs e)
        //{
        //    int realindex = getIndex();
        //    JYkdef.kdefdata tmpkdefdata = kdefevent.kdefdata[realindex].labelkdef;
        //    Frminstruct1 frm = new Frminstruct1(tmpkdefdata);
        //    frm.Show();
        //    kdefevent.kdefdata[realindex].labelkdef = frm.tmpdata;
        //}
        /// <summary>
        /// 获取真实的Index符号
        /// </summary>
        /// <returns></returns>
        //private int getIndex()
        //{
        //    int index = List2.SelectedItems[0].Index;
        //    int realindex = 0;
        //    for (int i = 0; i < index; i++)
        //    {
        //        if (List2.Items[i].SubItems.Count > 1)
        //        {
        //            realindex++;
        //        }
        //    }
        //    return realindex;
        //}
    }
}
