using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sfeadd;
using sfeGlobal;
namespace sfeKdef.kdef
{
    public partial class Frminstruct1 : Form
    {
        public JYkdef.kdefdata tmpdata = new JYkdef.kdefdata();
        public Frminstruct1(JYkdef.kdefdata kdefdata)
        {
            tmpdata = kdefdata;
            InitializeComponent();
            for (int i = 0; i < Global.headRle.Length; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.SelectedIndex = kdefdata.Data[2];
            textBox1.Text = Global.Talk[kdefdata.Data[1]];
            comboBox2.SelectedIndex = kdefdata.Data[3];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = comboBox1.SelectedIndex;
            Global.setBitmap(Global.headRle[Index], pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmptalkstr = string.Empty;
                    
            tmptalkstr = textBox1.Text.Replace("*","");
            //12个字符        
            tmptalkstr = Global.Talk_split(tmptalkstr, 12, "*");
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    Global.Talk[tmpdata.Data[1]] = textBox1.Text;
                    //Global.Talk[tmpdata.Data[1]] = textBox1.Text;
                    break;
                case 1:
                    Global.Talk.Add(tmptalkstr);
                    tmpdata.Data[1] = (short)(Global.Talk.Count - 1);
                    break;
            }
            tmpdata.Data[2] = (short)comboBox1.SelectedIndex;
            
            tmpdata.Data[3] = (short)comboBox2.SelectedIndex;
        }

    }
}
