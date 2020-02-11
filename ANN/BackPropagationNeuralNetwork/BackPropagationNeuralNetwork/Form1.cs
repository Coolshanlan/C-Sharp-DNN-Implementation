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
    public partial class Form1 : Form
    {
        DataTable LearnDt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLearnData_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                BackPropagationNeuralNetworkClass Network = new BackPropagationNeuralNetworkClass();
                DataTable trainTable = ExcelClass.CSVToTable(op.FileName);
                dataGridView1.DataSource = trainTable;
                MessageBox.Show("讀取");
                DataSet LearnDs = Network.Learn(trainTable, 50000, trainTable.Rows.Count, 0.5,0.1);
                chart1.Series[0].Points.Clear();
                foreach (DataRow dr in LearnDs.Tables["mseDt"].Rows)
                    chart1.Series[0].Points.AddXY(dr["Icycle"], dr["mse"]);
                dataGridView2.DataSource = LearnDs.Tables["learnDt"];
                LearnDt = LearnDs.Tables["learnDt"];
                dataGridView3.DataSource = LearnDs.Tables["mseDt"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackPropagationNeuralNetworkClass Network = new BackPropagationNeuralNetworkClass();
            string[] Xstr = textBox1.Text.Split(',');
            double[] x = new double[Xstr.Count()];
            for (int i = 0; i < Xstr.Count(); i++)
                x[i] = Convert.ToDouble(Xstr[i]);
            string s = "";
            foreach (double d in Network.Recall(LearnDt, x))
                s += d.ToString()+",";
            MessageBox.Show(s);
        }
    }
}
