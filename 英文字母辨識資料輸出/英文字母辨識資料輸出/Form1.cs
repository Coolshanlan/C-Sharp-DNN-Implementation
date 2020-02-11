using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 英文字母辨識資料輸出
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bp;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            pictureBox1.ImageLocation = op.FileName;
            bp = (Bitmap)Bitmap.FromFile(op.FileName) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] data = new string[121];
            for(int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 11; j++)
                {
                    data[i*11+ j] = bp.GetPixel(i,j).B>125?0.ToString():1.ToString();
                }
            }
            string s = "";
            for(int i = 0; i < 120; i++)
            {
                s += data[i] + "，";
            }
            s += data[120]+"/";
            s += textBox1.Text;
            StreamWriter sw = new StreamWriter("data.txt",true);
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
