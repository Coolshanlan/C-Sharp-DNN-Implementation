using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPropagationNeuralNetwork
{
    public partial class English : Form
    {
        public English()
        {
            InitializeComponent();
        }
        public string ans = ""; Button[] bb;
        int[,] AMask = new int[3, 3];
        int[,] BMask = new int[3, 3];
        int[,] CMask = new int[3, 3];
        int[,] DMask = new int[3, 3];
        int[,] EMask = new int[3, 3];
        int[,] FMask = new int[3, 3];
        private void English_Load(object sender, EventArgs e)
        {
            bb = new Button[121];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    bb[i * 11 + j] = new Button();
                    bb[i * 11 + j].Size = new Size(40, 40);
                    bb[i * 11 + j].Location = new Point(20 + j * 40, 20 + i * 40);
                    bb[i * 11 + j].FlatStyle = FlatStyle.Flat;
                    bb[i * 11 + j].MouseDown += new System.Windows.Forms.MouseEventHandler(this.bb_MouseDown);
                    bb[i * 11 + j].MouseUp += new System.Windows.Forms.MouseEventHandler(this.bb_MouseUp);
                    bb[i * 11 + j].MouseMove += new System.Windows.Forms.MouseEventHandler(this.bb_MouseMove);
                    bb[i * 11 + j].KeyDown += new System.Windows.Forms.KeyEventHandler(this.bb_KeyDown);
                    bb[i * 11 + j].KeyUp += new System.Windows.Forms.KeyEventHandler(this.bb_KeyUp);
                    this.Controls.Add(bb[i * 11 + j]);
                }
            }
            AMask[0, 0] = 0;
            AMask[1, 0] = 0;
            AMask[2, 0] = 1;
            AMask[0, 1] = 0;
            AMask[1, 1] = 1;
            AMask[2, 1] = 0;
            AMask[0, 2] = 1;
            AMask[1, 2] = 0;
            AMask[2, 2] = 0;

            BMask[0, 0] = 1;
            BMask[1, 0] = 0;
            BMask[2, 0] = 0;
            BMask[0, 1] = 0;
            BMask[1, 1] = 1;
            BMask[2, 1] = 0;
            BMask[0, 2] = 0;
            BMask[1, 2] = 0;
            BMask[2, 2] = 1;

            CMask[0, 0] = 0;
            CMask[1, 0] = 1;
            CMask[2, 0] = 0;
            CMask[0, 1] = 1;
            CMask[1, 1] = 1;
            CMask[2, 1] = 0;
            CMask[0, 2] = 0;
            CMask[1, 2] = 1;
            CMask[2, 2] = 0;

            DMask[0, 0] = 0;
            DMask[1, 0] = 0;
            DMask[2, 0] = 0;
            DMask[0, 1] = 0;
            DMask[1, 1] = 1;
            DMask[2, 1] = 0;
            DMask[0, 2] = 1;
            DMask[1, 2] = 1;
            DMask[2, 2] = 1;

            EMask[0, 0] = 0;
            EMask[1, 0] = 0;
            EMask[2, 0] = 0;
            EMask[0, 1] = 1;
            EMask[1, 1] = 1;
            EMask[2, 1] = 1;
            EMask[0, 2] = 0;
            EMask[1, 2] = 0;
            EMask[2, 2] = 0;

            FMask[0, 0] = 0;
            FMask[1, 0] = 1;
            FMask[2, 0] = 0;
            FMask[0, 1] = 0;
            FMask[1, 1] = 1;
            FMask[2, 1] = 0;
            FMask[0, 2] = 0;
            FMask[1, 2] = 1;
            FMask[2, 2] = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[,] ans_value = new int[11, 11];
            int[,] AMask_Value = new int[11, 11];
            int[,] BMask_Value = new int[11, 11];
            int[,] CMask_Value = new int[11, 11];
            int[,] DMask_Value = new int[11, 11];
            int[,] EMask_Value = new int[11, 11];
            int[,] FMask_Value = new int[11, 11];
            int[,] AMask_Value_p = new int[4, 4];
            int[,] BMask_Value_p = new int[4, 4];
            int[,] CMask_Value_p = new int[4, 4];
            int[,] DMask_Value_p = new int[4, 4];
            int[,] EMask_Value_p = new int[4, 4];
            int[,] FMask_Value_p = new int[4, 4];
            ans = "";
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    ans_value[i, j] = bb[i * 11 + j].BackColor == Color.Black ? 1 : 0;
                    ans += ans_value[i, j] + ",";
                }
            }
            ans = ans.Substring(0, ans.Length - 1);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int ii = -1; ii < 2; ii++)
                    {
                        for (int jj = -1; jj < 2; jj++)
                        {
                            if (i + ii < 0 || i + ii >= 11 || j + jj < 0 || j + jj >= 11) continue;
                            AMask_Value[i, j] += AMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                            BMask_Value[i, j] += BMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                            CMask_Value[i, j] += CMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                            DMask_Value[i, j] += DMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                            EMask_Value[i, j] += EMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                            FMask_Value[i, j] += EMask[ii + 1, jj + 1] * ans_value[i + ii, j + jj];
                        }
                    }
                    //sb.Append(CMask_Value[i,j] +" , ");
                }
                //sb.AppendLine();
            }
            sb = new StringBuilder();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(AMask_Value[i, j] + ",");
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(BMask_Value[i, j] + ",");
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(CMask_Value[i, j] + ",");
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(DMask_Value[i, j] + ",");
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(EMask_Value[i, j] + ",");
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sb.Append(FMask_Value[i, j] + ",");
                }
            }
            //sb.AppendLine();
            //sb.AppendLine();
            //for(int i = 0; i < 12; i += 3)
            //{
            //    for (int j = 0; j < 12; j += 3)
            //    {
            //        int Max = -3;
            //        for (int ii = i; ii < i + 3; ii++)
            //        {
            //            for(int jj = j; jj < j + 3; jj++)
            //            {
            //                if (ii >= 11 || jj >= 11) continue;
            //                if (AMask_Value_p[ii / 3, jj / 3] < AMask_Value[ii, jj])
            //                {
            //                    AMask_Value_p[ii / 3, jj / 3] = AMask_Value[ii, jj];
            //                }
            //                if (BMask_Value_p[ii / 3, jj / 3] < BMask_Value[ii, jj])
            //                {
            //                    BMask_Value_p[ii / 3, jj / 3] = BMask_Value[ii , jj ];
            //                }
            //                if (CMask_Value_p[ii / 3, jj / 3] < CMask_Value[ii, jj])
            //                {
            //                    CMask_Value_p[ii / 3, jj / 3] = CMask_Value[ii , jj ];
            //                }
            //                if (DMask_Value_p[ii / 3, jj / 3] < DMask_Value[ii, jj])
            //                {
            //                    DMask_Value_p[ii / 3, jj / 3] = DMask_Value[ii , jj ];
            //                }
            //                if (EMask_Value_p[ii / 3, jj / 3] < EMask_Value[ii, jj])
            //                {
            //                    EMask_Value_p[ii / 3, jj / 3] = EMask_Value[ii , jj ];
            //                }
            //                if (FMask_Value_p[ii / 3, jj / 3] < FMask_Value[ii, jj])
            //                {
            //                    FMask_Value_p[ii / 3, jj / 3] = FMask_Value[ii, jj];
            //                }
            //            }
            //        }
            //    }
            //}
            //sb = new StringBuilder();
            //for(int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(AMask_Value_p[i,j]+",");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(BMask_Value_p[i, j] + ",");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(CMask_Value_p[i, j] + ",");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(DMask_Value_p[i, j] + ",");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(EMask_Value_p[i, j] + ",");
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(FMask_Value_p[i, j] + ",");
            //    }
            //}
            sb.Remove(sb.Length - 1, 1);
            textBox1.Text = sb.ToString();
            ans = sb.ToString();
        }
        bool down = false;
        private void bb_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
        }
        private void bb_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }
        private void bb_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (down) b.BackColor = Color.Black;
        }
        private void bb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) down = true;
        }
        private void bb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) down = false;
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
