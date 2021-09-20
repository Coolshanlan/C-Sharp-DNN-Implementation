using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace BackPropagationNeuralNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Data = new DataTable();
        DataTable Val_Data = new DataTable();
        DataTable mse_table = new DataTable();
        BackPropagation_NeuralNetwork bn = new BackPropagation_NeuralNetwork();
        int Last_Rows_Count = 0;
        string learn_path = "";
        private void Select_Data_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                ReadData rd = new ReadData();
                Last_Rows_Count = 0;
                mse_table = new DataTable("History");
                mse_table.Columns.Add("Times");
                mse_table.Columns.Add("T_Loss");
                mse_table.Columns.Add("T_Acc");
                mse_table.Columns.Add("V_Loss");
                mse_table.Columns.Add("V_Acc");
                dataGridView2.DataSource = mse_table;
                chat1.Series[0].Points.Clear();
                chat1.Series[1].Points.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                var tmp_Data = rd.txtToDatatable(op.FileName);
                Data = (DataTable)tmp_Data[0];
                Val_Data = (DataTable)tmp_Data[1];

                learn_path = op.FileName;
                filename_txt.Text = op.SafeFileName.Substring(0, op.SafeFileName.IndexOf('.'));
                if( insertlearn_txt.Text == "")
                outlearn_txt.Text = op.SafeFileName.Substring(0,op.SafeFileName.IndexOf('.')) + "_Learn";
                double Max = 0;
                foreach(DataRow dr in Data.Rows)
                {
                    dr[0] = dr[0].ToString().Replace("，",",");
                    dr[0] = dr[0].ToString().Replace(" ", ",");
                    string[] s = dr[0].ToString().Split(',');
                    foreach(var a in s)
                    {
                        if (Max < double.Parse(a.ToString())) Max = double.Parse(a.ToString());
                    }
                }
                foreach (DataRow dr in Val_Data.Rows)
                {
                    dr[0] = dr[0].ToString().Replace("，", ",");
                    dr[0] = dr[0].ToString().Replace(" ", ",");
                    string[] s = dr[0].ToString().Split(',');
                    foreach (var a in s)
                    {
                        if (Max < double.Parse(a.ToString())) Max = double.Parse(a.ToString());
                    }
                }
                label15.Text = "1 / " + Data.Rows.Count;
                label15.Location = new Point(424 - (label15.Width / 2), 30);
                label17.Text = "1 / " + Val_Data.Rows.Count;
                //label17.Location = new Point(424 - (label17.Width / 2), 90);
                num_txt.Text = Max + "";
                dataGridView1.DataSource = Data;
                dataGridView4.DataSource = Val_Data;
                checkBox1.Checked = true;
                button1.Enabled = true;
                op = new OpenFileDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chat1.Series[0].Name = "TLoss";
            chat1.Series[0].BorderWidth = 4;
            chat1.Series[1].Name = "VLoss";
            chat1.Series[1].BorderWidth = 4;
            chart1.Series[0].Name = "TAcc";
            chart1.Series[0].BorderWidth = 4;
            chart1.Series[1].Name = "VAcc";
            chart1.Series[1].BorderWidth = 4;
            label13.Font = label12.Font;
            label14.Font = label12.Font;
            label14.BackColor = Color.White;
            CheckForIllegalCrossThreadCalls = false;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = mse_table;
        }
        private void Learn_Click(object sender, EventArgs e)
        {
            Learn.Enabled = false;
            checkBox2.Enabled = false;
            if (dataGridView1.DataSource == null)
            {
                Select_Data.PerformClick();
                return;
            }
            if (checkBox1.Checked)
            {
                mse_table.Rows.Clear();
                bn = new BackPropagation_NeuralNetwork();
                Last_Rows_Count = 0;
                chat1.Series[0].Points.Clear();
                chat1.Series[1].Points.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                //chat1 = new Chart();
                //chat1.Series.Add("") ;
                if (dataGridView2.Rows.Count != 0)
                    dataGridView2.DataSource = mse_table;
            }
            bn.Run_Times = 0;
            Task.Run(() =>
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(mse_progress));
                
                progressBar1.Maximum = int.Parse(times_txt.Text);
                progressBar1.Value = 0;
                t1.IsBackground = true;
               
                bn.stop = false;
                t1.Start(int.Parse(times_txt.Text));
                //Thread t2 = new Thread(new ParameterizedThreadStart(classes_progress));
                //if (checkBox2.Checked)
                //{
                //    //Thread t2 = new Thread(new ParameterizedThreadStart(classes_progress));
                //    t2.IsBackground = true;
                //    t2.Start(int.Parse(times_txt.Text));
                //}
                //if(checkBox1.Checked)
                //mse_table = bn.Learn_Clear(Data, int.Parse(times_txt.Text), double.Parse(eta_txt.Text), double.Parse(alpha_txt.Text), int.Parse(HidLong_txt.Text), double.Parse(num_txt.Text), int.Parse(hidcount_txt.Text), checkBox1.Checked);
                //this.Invoke(new mse_Data(mse_Data_show), new object[] { mse_table, chat1, dataGridView2 });
                //dataGridView2.DataSource = mse_table;
                List<In_D> dd = new List<In_D>();
                foreach(DataRow dr in Data.Rows)
                {
                    //if(dd.ToList().FindAll(x=>x.data == dr[0].ToString()).Count ==0)
                    dd.Add(new In_D() { data = dr[0].ToString() , ans = dr[1].ToString()}) ;
                }
                List<In_D> vd = new List<In_D>();
                foreach (DataRow dr in Val_Data.Rows)
                {
                    //if (vd.ToList().FindAll(x => x.data == dr[0].ToString()).Count == 0)
                        vd.Add(new In_D() { data = dr[0].ToString(), ans = dr[1].ToString() });
                }
                List<List<double>> mse_d = bn.Learn(dd,vd, int.Parse(times_txt.Text), double.Parse(eta_txt.Text), double.Parse(alpha_txt.Text), int.Parse(HidLong_txt.Text), double.Parse(num_txt.Text), int.Parse(hidcount_txt.Text), checkBox1.Checked,Convert.ToDouble(textBox1.Text));
                t1.Abort();
                //t2.Abort();
                this.Invoke(new mse_Data(mse_Data_show), new object[] { mse_d, chat1,chart2, dataGridView2 });
                //bn.Learn(Data, int.Parse(times_txt.Text), double.Parse(eta_txt.Text), double.Parse(alpha_txt.Text), int.Parse(HidLong_txt.Text), double.Parse(num_txt.Text), int.Parse(hidcount_txt.Text), checkBox1.Checked);
                Inputbu.Enabled = true;
                //BatchIn_Bu.Enabled = true ;
                outpulearn_bu.Enabled = true;
                checkBox1.Checked = false;
                Learn.Enabled = true;
                checkBox2.Enabled = true;
                print_Weight();
            });
        }
        public void mse_progress( object All_times)
        {
            double mse = 0.0;
            while ( bn.Run_Times == 0)
            {
                Thread.Sleep(10);
            }
            progressBar1.Value = 0;
            while (progressBar1.Value != (int)All_times && !bn.stop)
            {
                Thread.Sleep(10);
                while (progressBar1.Value == bn.Run_Times)
                {
                    if (bn.stop)
                    {
                        return;
                    }
                    Thread.Sleep(10);
                }
                //Application.DoEvents();
                //DataRow dr = mse_table.NewRow();
                //dr[0] = mse_table.Rows.Count + 1;
                //dr[1] = bn.mse_now;
                //mse_table.Rows.Add(dr);
                progressBar1.Value = bn.Run_Times;
                label12.Text = bn.Run_Times+" / "+All_times.ToString();
                label13.Text = "Mse：" +bn.mse_now.ToString();
                label14.Text = "斜率：" + Math.Round((bn.mse_now - mse), 6).ToString();
                mse = bn.mse_now;
                if (checkBox2.Checked)
                {
                    chat1.Series[0].Points.AddY(bn.mse_now.ToString());
                    chat1.Series[1].Points.AddY(bn.val_mse_now.ToString());
                    chart1.Series[0].Points.AddY(bn.acc_now.ToString());
                    chart1.Series[1].Points.AddY(bn.val_acc_now.ToString());
                }
                
                label12.Location = new Point(1204-360 - (label12.Width / 2), 660-50);
                label13.Location = new Point(1204 -360- (label13.Width / 2), 639-50);
                label14.Location = new Point(1204 -360-(label14.Width / 2), 618-50);

            }
        }
        public void classes_progress(object All_times)
        {
            double mse = 0.0;
            while (bn.Run_Times == 0)
            {

                Thread.Sleep(10);
            }
            progressBar1.Value = 0;
            while (progressBar1.Value != (int)All_times && !bn.stop)
            {
                Thread.Sleep(10);
                while (progressBar1.Value == bn.Run_Times)
                {
                    if (bn.stop)
                    {
                        return;
                    }
                    Thread.Sleep(10);
                }
                while(bn.outputanswers == null)
                {
                    Thread.Sleep(10);
                }
                lock (chart2.Series[0].Points)
                {
                    int[] outtmp = bn.outputanswers.ToArray();
                    for(int i = 0; i < chart2.Series.Count; i++)
                    {
                        chart2.Series[i].Points.Clear();
                    }
                    chart2.Series.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Series classseries = new System.Windows.Forms.DataVisualization.Charting.Series();
                    classseries.ChartArea = "ChartArea1";
                    classseries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    classseries.Legend = "Legend1";
                    classseries.Name = "Series0";
                    chart2.Series.Add(classseries);
                    for (int i = 0; i < bn.NOut; i++)
                    {
                        System.Windows.Forms.DataVisualization.Charting.Series seriesdynamic = new System.Windows.Forms.DataVisualization.Charting.Series();
                        seriesdynamic.ChartArea = "ChartArea1";
                        seriesdynamic.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                        seriesdynamic.Legend = "Legend1";
                        seriesdynamic.Name = "Series" + (i + 1);
                        chart2.Series.Add(seriesdynamic);
                    }
                    for (int i = 0; i < Data.Rows.Count; i++)
                    {
                        string[] intmp = Data.Rows[i][0].ToString().Split(',');
                        chart2.Series[outtmp[i] + 1].Points.AddXY(Convert.ToDouble(intmp[0]), Convert.ToDouble(intmp[1]));
                    }
                    for (int i = 0; i < Val_Data.Rows.Count; i++)
                    {
                        string[] intmp = Val_Data.Rows[i][0].ToString().Split(',');
                        chart2.Series[outtmp[i + Data.Rows.Count - 1] + 1].Points.AddXY(Convert.ToDouble(intmp[0]), Convert.ToDouble(intmp[1]));
                    }
                }
            }
        }
        public void mse_Data_show(List<List<double>> dd  , Chart chat , Chart chat2, DataGridView dw)
        {
            int countt = dataGridView2.Rows.Count;
            int count = 0;
            DataTable dt = new DataTable();
            foreach(var a in mse_table.Columns)
            {
                dt.Columns.Add(a.ToString());
            }
            foreach (DataGridViewRow a in dw.Rows)
            {
                DataRow dr = dt.NewRow();
                dr[0] = ++count;
                dr[1] = a.Cells[1].Value.ToString();
                dr[2] = a.Cells[2].Value.ToString();
                dr[3] = a.Cells[3].Value.ToString();
                dr[4] = a.Cells[4].Value.ToString();
                dt.Rows.Add(dr);
            }
            foreach (var a in dd)
            {
                DataRow dr = dt.NewRow();
                dr[0] = ++countt;
                dr[1] = a[0].ToString();
                dr[2] = a[1].ToString();
                dr[3] = a[2].ToString();
                dr[4] = a[3].ToString();
                dt.Rows.Add(dr);
            }

            dw.DataSource = dt;
            dw.ScrollBars = ScrollBars.Both;
            if(!checkBox2.Checked)
            for (int i = Last_Rows_Count; i < dt.Rows.Count; i++)
            {
                chat.Series[0].Points.AddY(dt.Rows[i][1]);
                chat.Series[1].Points.AddY(dt.Rows[i][3]);
                chart1.Series[0].Points.AddY(dt.Rows[i][2]);
                chart1.Series[1].Points.AddY(dt.Rows[i][4]);
            }
            else
            {
                chat.Series[0].Points.Clear();
                chat.Series[1].Points.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chat.Series[0].Points.AddY(dt.Rows[i][1]);
                    chat.Series[1].Points.AddY(dt.Rows[i][3]);
                    chart1.Series[0].Points.AddY(dt.Rows[i][2]);
                    chart1.Series[1].Points.AddY(dt.Rows[i][4]);
                }
            }
            chart2.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series classseries = new System.Windows.Forms.DataVisualization.Charting.Series();
            classseries.ChartArea = "ChartArea1";
            classseries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            classseries.Legend = "Legend1";
            classseries.Name = "Series0";
            chart2.Series.Add(classseries);
            for (int i = 0; i < bn.NOut; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.Series seriesdynamic = new System.Windows.Forms.DataVisualization.Charting.Series();
                seriesdynamic.ChartArea = "ChartArea1";
                seriesdynamic.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                seriesdynamic.Legend = "Legend1";
                seriesdynamic.Name = "Series"+(i+1);
                chart2.Series.Add(seriesdynamic);
            }
            for (int i = 0; i < Data.Rows.Count; i++)
            {
                string[] intmp = Data.Rows[i][0].ToString().Split(',');
                chart2.Series[bn.outputanswers[i] + 1].Points.AddXY(Convert.ToDouble(intmp[0]), Convert.ToDouble(intmp[1]));
            }
            for (int i = 0; i < Val_Data.Rows.Count; i++)
            {
                string[] intmp = Val_Data.Rows[i][0].ToString().Split(',');
                chart2.Series[bn.outputanswers[i+ Data.Rows.Count] + 1].Points.AddXY(Convert.ToDouble(intmp[0]), Convert.ToDouble(intmp[1]));
            }
            //for (int i = Last_Rows_Count; i < dt.Rows.Count; i++)
            //{
            //    chat.Series[1].Points.AddY(dt.Rows[i][3]);
            //}
            Last_Rows_Count = dw.Rows.Count;
        }
        public delegate void data_update(DataGridView dw,object times);
        public delegate void mse_Data(List<List<double>> dd, Chart c, Chart c2, DataGridView dw);
        public delegate void Go_learn(DataTable dt, int Learn_Times, double eta, double alpha, int Hid_Long, double num, int hidcount, bool clear, Chart chat);
        //private void Calldelegate()
        //{
        //    /*在Windows窗体应用程序中使用this.Invoke    在WPF应用程序中使用this.Dispatcher.Invoke*/
        //        this.BeginInvoke(new Go_learn(bn.Learn), new object[] { Data, int.Parse(times_txt.Text), double.Parse(eta_txt.Text), double.Parse(alpha_txt.Text), int.Parse(HidLong_txt.Text), double.Parse(num_txt.Text), int.Parse(hidcount_txt.Text), checkBox1.Checked, chat1 });      
        //    //this.Dispatcher.BeginInvoke(new UpdateForm_dl(UpdateForm), new object[] { "我是文本框", "haha" });
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string data = data_txt.Text;
            try
            {
                List<double> reb = bn.Recall(data, double.Parse(num_txt.Text));
                for(int i = 0; i < reb.Count; i++)
                {
                    dt.Columns.Add(Convert.ToChar(65+ i).ToString());
                }
                DataRow dr = dt.NewRow();
                for (int i = 0; i < reb.Count; i++)
                {
                    dr[i] = reb[i].ToString();
                }
                dt.Rows.Add(dr);
            }
            catch
            {
                MessageBox.Show("輸入錯誤\r\n\r\n資料請以   ，   分割");
                return;
            }
            Revise_bu.Enabled = true;
            //BatchRe_Bu.Enabled = true;
            dataGridView3.DataSource = dt;
            int Max = 0;
            double value = 0;
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                if (value < double.Parse(dt.Rows[0][i].ToString()))
                {
                    value = double.Parse(dt.Rows[0][i].ToString());
                    Max = i;
                }
            }
            dataGridView3.Rows[0].Cells[Max].Style.BackColor = Color.LightPink;
        }
        private void data_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Inputbu.PerformClick();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() != DialogResult.OK) return;
            Last_Rows_Count = 0;
            outlearn_txt.Text = op.SafeFileName.Substring(0, op.SafeFileName.IndexOf('.'));
            StreamReader sr = new StreamReader(op.FileName);
            mse_table = new DataTable("History");
            mse_table.Columns.Add("Times");
            mse_table.Columns.Add("T_Loss");
            mse_table.Columns.Add("T_Acc");
            mse_table.Columns.Add("V_Loss");
            mse_table.Columns.Add("V_Acc");
            dataGridView2.DataSource = mse_table;
            string s = sr.ReadToEnd();
            s = s.Replace("\r\n","。");
            List<string> data = s.Split('。').ToList();
            data.RemoveAt(data.Count-1);
            string d = data[0];
            chat1.Series[0].Points.Clear();
            chat1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            string[] d_value = d.Split(',');
            eta_txt.Text = d_value[0];
            alpha_txt.Text = d_value[1];
            HidLong_txt.Text = d_value[2];
            hidcount_txt.Text =  d_value[3];
            num_txt.Text  = d_value[4];

            data.RemoveAt(0);

            bn.Insert_LearnData(data);

            insertlearn_txt.Text = op.SafeFileName;
            checkBox1.Checked = false;
            Inputbu.Enabled = true;
            //BatchIn_Bu.Enabled = true;
            outpulearn_bu.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            English en = new English();
            en.ShowDialog();
            string data = en.ans;
            data_txt.Text = data;
        }
        private void print_Weight()
        {
            textBox2.Text = "";
            textBox2.Text += "-------------- Input Layer --------------\r\n\r\n";
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
            textBox2.Refresh();
            for (int i = 1; i < bn.neurons_count; i++)
            {
                               
                foreach (var aa in bn.neur[i])
                {
                   
                    foreach (var aaa in aa.W_value)
                    {
                        textBox2.Text += aaa + "\r\n";
                        textBox2.SelectionStart = textBox2.Text.Length;
                        textBox2.ScrollToCaret();
                        textBox2.Refresh();
                        if (Learn.Enabled == false)
                        {
                            textBox2.Text = "";
                            return;
                        }
                    }
                    textBox2.Text += "\r\n" + aa.Q_value + "\r\n\r\n";
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.ScrollToCaret();
                    textBox2.Refresh();
                }
                if (i != bn.neurons_count - 1)
                {
                    textBox2.Text += "-------------- Hidden Layer " + i + "--------------\r\n\r\n";
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.ScrollToCaret();
                    textBox2.Refresh();
                }
            }
            textBox2.Text += "-------------- Ouput Layer --------------\r\n";
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
            textBox2.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb =new StringBuilder();

            sb.Append(eta_txt.Text+",");
            sb.Append(alpha_txt.Text + ",");
            sb.Append(HidLong_txt.Text + ",");
            sb.Append(hidcount_txt.Text + ",");
            sb.AppendLine(num_txt.Text);

            sb.Append(bn.NIn+",");
            sb.Append(bn.NHid+",");
            sb.AppendLine(bn.NOut+"");

            foreach(var a in bn.neur)
            {
                foreach(var aa in a)
                {
                    foreach(var aaa in aa.W_value)
                    {
                        sb.Append(aaa+",");
                    }
                    foreach(var aaa in aa.dW_value)
                    {
                        sb.Append(aaa + ",");
                    }
                    sb.Append(aa.Q_value+",");
                    sb.Append(aa.dQ_value+",");
                    sb.Append(aa.delta);
                    sb.Append("+");
                }
                sb.Remove(sb.Length-1,1);
                sb.AppendLine();
            }
            string filename = outlearn_txt.Text;
            if (filename == "") filename = filename_txt.Text + "_learn";
            StreamWriter sw = new StreamWriter(Path.GetFullPath("..\\..\\..\\Learn_Data\\"+filename+".txt"),false) ;
            sw.Write(sb.ToString());
            sw.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                double[] ans = Array.ConvertAll(Revise_txt.Text.Split(','),Convert.ToDouble);
                if(ans.Count() != Data.Rows[0][1].ToString().Split(',').Count())
                {
                    MessageBox.Show("答案長度錯誤！");
                    return;
                }
                DataRow dr = Data.NewRow();
                foreach(DataRow a in Data.Rows)
                {
                    if (a[0].ToString() == data_txt.Text) return;
                }
                dr[0] = data_txt.Text;
                dr[1] = Revise_txt.Text;
                Data.Rows.Add(dr);
                dataGridView1.DataSource = Data;
                label15.Text = cell_select + " / " + Data.Rows.Count;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Data.Rows.Count; i++)
            {
              sb.AppendLine(Data.Rows[i][0].ToString().Replace(',',' ') + " " + (Data.Rows[i][1].ToString().Split(',').ToList().IndexOf("1")+1));
            }
            for (int i = 0; i < Val_Data.Rows.Count - 1; i++)
            {
                sb.AppendLine(Val_Data.Rows[i][0].ToString().Replace(',', ' ') + " " + (Val_Data.Rows[i][1].ToString().Split(',').ToList().IndexOf("1") + 1));
            }
            sb.Append(Data.Rows[Val_Data.Rows.Count-1][0].ToString().Replace(',', ' ') + " " + (Data.Rows[Val_Data.Rows.Count-1][1].ToString().Split(',').ToList().IndexOf("1") + 1));
            StreamWriter sw = new StreamWriter(learn_path);
            sw.Write(sb);
            sw.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            bn.stop = true;
            checkBox2.Enabled = true;
            //dataGridView2.ScrollBars = new ScrollBars();
            //dataGridView2.ScrollBars = ScrollBars.None ;
            //dataGridView2.ScrollBars = ScrollBars.Vertical;
            //Application.DoEvents();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }
        int cell_select = 1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cell_select = (e.RowIndex + 1);
            label15.Text = (e.RowIndex + 1) + " / " + Data.Rows.Count;
            label15.Location = new Point(424 - (label15.Width / 2), 30);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void chat1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Revise_txt_TextChanged(object sender, EventArgs e)
        {

        }
        //DataTable Batch_Data = new DataTable();
        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();

        //    DataTable mse_table_2 = new DataTable();

        //    if (op.ShowDialog() == DialogResult.OK)
        //    {
        //        ReadData rd = new ReadData();

        //        mse_table_2 = new DataTable("Mse");
        //        mse_table_2.Columns.Add("Times");
        //        mse_table_2.Columns.Add("Mse");
        //        //Batch_Data = rd.txtToDatatable(op.FileName);



        //        op = new OpenFileDialog();

        //        int correct = 0;

        //        DataTable dt = new DataTable();


        //        for (int i = 0; i < Batch_Data.Rows[0][1].ToString().Split(',').Count(); i++)
        //        {
        //            dt.Columns.Add(Convert.ToChar(65 + i).ToString());
        //        }

        //        foreach (DataRow data_dr in Batch_Data.Rows)
        //        {
        //            dt.Rows.Clear();
        //            string data = data_dr[0].ToString();
        //            string ans = data_dr[1].ToString();
        //            try
        //            {
        //                List<double> reb = bn.Recall(data, double.Parse(num_txt.Text));
        //                if (ans.Split(',').Count() != reb.Count)
        //                {
        //                    MessageBox.Show("答案長度錯誤！");
        //                    return;
        //                }

        //                DataRow dr = dt.NewRow();
        //                for (int i = 0; i < reb.Count; i++)
        //                {
        //                    dr[i] = reb[i].ToString();
        //                }
        //                dt.Rows.Add(dr);
        //            }
        //            catch
        //            {
        //                MessageBox.Show("輸入錯誤\r\n\r\n資料請以   ，   分割");
        //                return;
        //            }
        //            dataGridView3.DataSource = dt;
        //            int Max = 0;
        //            double value = 0;
        //            for (int i = 0; i < dt.Columns.Count; i++)
        //            {
        //                if (value < double.Parse(dt.Rows[0][i].ToString()))
        //                {
        //                    value = double.Parse(dt.Rows[0][i].ToString());
        //                    Max = i;
        //                }
        //            }
        //            if (ans.Split(',')[Max].ToString() == "1") correct++;
        //            dataGridView3.Rows[0].Cells[Max].Style.BackColor = Color.LightPink;
        //        }
        //        //BatchRe_Bu.Enabled = true;
        //        label16.Text = correct.ToString() + "/" + Batch_Data.Rows.Count + "(" + (((double)correct / (double)Batch_Data.Rows.Count)*100).ToString("0.00") + "%)";
        //        label16.Location = new Point(75-label16.Width/2,640);


        //    }
        //}

        //private void BatchRe_Bu_Click(object sender, EventArgs e)
        //{
        //    foreach(DataRow bd in Batch_Data.Rows)
        //    {
        //        string data_string = bd[0].ToString();
        //        string ans_string = bd[1].ToString();
        //        if (ans_string.Split(',').Count() != Data.Rows[0][1].ToString().Split(',').Count())
        //        {
        //            MessageBox.Show("答案長度錯誤！");
        //            return;
        //        }
        //        DataRow dr = Data.NewRow();
        //        bool have = false;
        //        foreach (DataRow a in Data.Rows)
        //        {
        //            if (a[0].ToString() == data_string)
        //            {
        //                have = true;
        //                break;
        //            }
        //        }
        //        if (!have)
        //        {
        //            dr[0] = data_string;
        //            dr[1] = ans_string;
        //            Data.Rows.Add(dr);
        //        }
        //    }
        //    dataGridView1.DataSource = Data;
        //    label15.Text = cell_select + " / " + Data.Rows.Count;
        //}

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
