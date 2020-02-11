using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace BackPropagationNeuralNetwork
{
    class BackPropagation_NeuralNetwork
    {
        public int data_count;
        public int neurons_count;
        public int NIn;
        public int NOut;
        public int NHid;
        public Neurons[][] neur;
        public int Run_Times = -1;
        public double mse = 0.0;
        public bool stop = false;
        public double mse_now = 0.0;

        public bool Insert_LearnData(List<string> data)
        {
            try
            {

                string[] s = data[0].Split(',');
                //計算神經元數量 
                NIn = int.Parse(s[0]);
                NOut = int.Parse(s[2]);
                NHid = int.Parse(s[1]);

                data.RemoveAt(0);

                neurons_count = data.Count;

                //宣告個神經元
                neur = new Neurons[neurons_count][];
                neur[0] = new Neurons[NIn];
                neur[neur.Count() - 1] = new Neurons[NOut];
                for (int n_hid = 1; n_hid < neurons_count - 1; n_hid++)
                    neur[n_hid] = new Neurons[NHid];

                //初始化神經元
                for (int j = 0; j < neur[0].Length; j++)
                {
                    neur[0][j] = new Neurons();
                    neur[0][j].Clear(NIn);
                }
                for (int i = 1; i < neur.Length; i++)
                {
                    for (int j = 0; j < neur[i].Length; j++)
                    {
                        neur[i][j] = new Neurons();
                        neur[i][j].Clear(neur[i - 1].Length);
                    }
                }
                for (int i = 0; i < data.Count; i++)
                {
                    List<string> d = data[i].Split('+').ToList();
                    for (int j = 0; j < d.Count(); j++)
                    {
                        List<string> dd = d[j].Split(',').ToList();
                        for (int w = 0; w < neur[i][j].W_value.Count(); w++)
                        {
                            neur[i][j].W_value[w] = double.Parse(dd[0]);
                            if (Single.IsNaN((float)neur[i][j].W_value[w]))
                            {

                            }
                            dd.RemoveAt(0);
                        }
                        for (int w = 0; w < neur[i][j].dW_value.Count(); w++)
                        {
                            neur[i][j].dW_value[w] = double.Parse(dd[0]);
                            dd.RemoveAt(0);
                        }

                        neur[i][j].Q_value = double.Parse(dd[0]);
                        dd.RemoveAt(0);
                        neur[i][j].dQ_value = double.Parse(dd[0]);
                        dd.RemoveAt(0);
                        neur[i][j].delta = double.Parse(dd[0]);
                        dd.RemoveAt(0);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Output_LearnData(double eta , double alpha , double HidLong , double Hidcount , double num , string filename)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(eta + ",");
            sb.Append(alpha + ",");
            sb.Append(HidLong + ",");
            sb.Append(Hidcount + ",");
            sb.AppendLine(num+"");

            sb.Append(NIn + ",");
            sb.Append(NHid + ",");
            sb.AppendLine(NOut + "");

            foreach (var a in neur)
            {
                foreach (var aa in a)
                {
                    foreach (var aaa in aa.W_value)
                    {
                        sb.Append(aaa + ",");
                    }
                    foreach (var aaa in aa.dW_value)
                    {
                        sb.Append(aaa + ",");
                    }
                    sb.Append(aa.Q_value + ",");
                    sb.Append(aa.dQ_value + ",");
                    sb.Append(aa.delta);
                    sb.Append("+");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            if (filename.Trim() == "") filename = "Learn_Data_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") ;
            StreamWriter sw = new StreamWriter(Path.GetFullPath("..\\..\\..\\Learn_Data\\" + filename + ".txt"), false);
            sw.Write(sb.ToString());
            sw.Close();
        }

        public void Learn_Reset(List<In_D> dt, int Hid_Long,  int hidcount)//初始化神經元
        {
            data_count = dt.Count;
            neurons_count = Hid_Long + 2;
            //計算神經元數量 
            //NIn = dt.ElementAt(0).Key.ToString().Split(',').Count();
            //NOut = dt.ElementAt(0).Value.ToString().Split(',').Count();
            NIn = dt[0].data.ToString().Split(',').Count();
            NOut = dt[0].ans.ToString().Split(',').Count();
            NHid = (NIn + NOut) / 2 + hidcount;

            //宣告個神經元
            neur = new Neurons[Hid_Long + 2][];
            neur[0] = new Neurons[NIn];
            neur[neur.Count() - 1] = new Neurons[NOut];
            for (int n_hid = 1; n_hid < Hid_Long + 1; n_hid++)
                neur[n_hid] = new Neurons[NHid];

            //初始化神經元
            for (int j = 0; j < neur[0].Length; j++)
            {
                neur[0][j] = new Neurons();
                neur[0][j].Clear(NIn);
            }
            for (int i = 1; i < neur.Length; i++)
            {
                for (int j = 0; j < neur[i].Length; j++)
                {
                    neur[i][j] = new Neurons();
                    neur[i][j].Clear(neur[i - 1].Length);
                }
            }
        }

        public  List<double> Learn(List<In_D> dt,int Learn_Times,double eta , double alpha,int Hid_Long,double num,int hidcount,bool clear,double max_mse )
        {
            List<double> learndt_mse = new List<double>();
            data_count = dt.Count;
            neurons_count = Hid_Long + 2;
            //NIn = dt.ElementAt(0).Key.ToString().Split(',').Count();
            //NOut = dt.ElementAt(0).Value.ToString().Split(',').Count();
            NIn = dt[0].data.ToString().Split(',').Count();
            NOut = dt[0].ans.ToString().Split(',').Count();
            NHid = (NIn + NOut) / 2 + hidcount;
            if (clear) Learn_Reset(dt,Hid_Long,hidcount);
            //學習開始
            for (Run_Times = 0; Run_Times < Learn_Times; Run_Times++)//學習次數
            {
                mse = 0.0;
                if (stop) return learndt_mse;
                for (int d_t = 0; d_t < data_count; d_t++)//學習樣本數
                {

                    double[] Data_Ans;
                    double[] Data_delta = new double[NOut];
                    //資料取出
                    string in_s = dt[d_t].data.ToString();
                    string out_s = dt[d_t].ans.ToString();
                    string[] in_a = in_s.Split(',');
                    string[] out_a = out_s.Split(',');

                    //資料輸入
                    for (int in_t = 0; in_t < NIn; in_t++)
                        neur[0][in_t].Output_value = Convert.ToDouble(in_a[in_t]) / num;
                    Data_Ans = Array.ConvertAll(out_a,Convert.ToDouble);

                    //計算輸出值
                    for(int i = 1; i < neurons_count; i++)
                    {
                        int len = neur[i - 1].Length;
                        double[] input_data = new double[len];
                        for(int j = 0; j < len; j++)
                        {
                            input_data[j] = neur[i - 1][j].Output_value;
                        }
                        for(int j =0;j< neur[i].Length; j++)
                        {
                            neur[i][j].Input_Update(input_data);
                            if (i == neurons_count-1)
                                neur[i][j].Output_Update_Out();
                            else
                                neur[i][j].Output_Update();
                        }
                    }
                    //修正加權值，誤差值累計
                    mse += Revise(Data_Ans,eta,alpha);
                }
                learndt_mse.Add(Math.Round((double)(mse / data_count), 15));
                mse_now = Math.Round((double)(mse / data_count), 6);
                if (mse_now < max_mse) return learndt_mse;
            }
            return learndt_mse;
        }

        public double Revise(double[] Data_Ans,double eta , double alpha)//修正加權值
        {
            double mse = 0.0;
            double sum_softmax = 0.0;

            //for (int i = 0; i < NOut; i++)
            //{
            //    double out_value = neur[neurons_count - 1][i].Output_value;
            //    double out_ans = Data_Ans[i];
            //    neur[neurons_count - 1][i].delta_Update((out_ans - out_value));
            //    mse += (out_ans - out_value) * (out_ans - out_value);
            //}

            //softmax---------------------
            //輸出加總
            for (int i = 0; i < NOut; i++)
            {
                //sum_softmax += neur[neurons_count - 1][i].ActivationFunction(neur[neurons_count - 1][i].Output_value);
                sum_softmax += neur[neurons_count - 1][i].Output_value;
                //neur[neurons_count - 1][i].Output_value = neur[neurons_count - 1][i].ActivationFunction(neur[neurons_count - 1][i].Output_value);
            }

            
            //計算誤差值
            for (int i = 0; i < NOut; i++)
            {
                double out_value = neur[neurons_count - 1][i].Output_value / sum_softmax;
                neur[neurons_count - 1][i].Output_value = out_value;
                double out_ans = Data_Ans[i];
                neur[neurons_count - 1][i].delta_Update((out_ans - out_value));
                mse += (out_ans - out_value) * (out_ans - out_value);
            }
            //softmax---------------------

            //更新加權值
            for (int i = neurons_count - 1; i > 1; i--)//層
            {
                int len = neur[i - 1].Length;
                double[] sum = new double[len];
                for (int j = 0; j < neur[i].Length; j++)//神經元
                {
                    for (int z = 0; z < len; z++)
                    {
                        sum[z] += neur[i][j].delta * neur[i][j].W_value[z];
                    }
                }
                for (int j = 0; j < len; j++)
                {
                    neur[i - 1][j].delta_Update(sum[j]);
                }
            }

            foreach (var a in neur)
            {
                foreach (var aa in a)
                {
                    aa.Diff_Weight_Update(eta, alpha);
                    aa.Weight_Update();
                }
            }

            return mse;
        }

        public List<double> Recall(string data,double num)//輸入資料以回傳結果(不做修正)
        {

            List<double> Out_Put = new List<double>();

            //資料取出
            string[] in_a = data.Split(',');

            //資料輸入
            for (int in_t = 0; in_t < NIn; in_t++)
                neur[0][in_t].Output_value = Convert.ToDouble(in_a[in_t]) / num;

            //計算輸出值
            for (int i = 1; i < neurons_count; i++)
            {
                int len = neur[i - 1].Length;
                double[] input_data = new double[len];
                for (int j = 0; j < len; j++)
                {
                    input_data[j] = neur[i - 1][j].Output_value;
                }
                for (int j = 0; j < neur[i].Length; j++)
                {
                    neur[i][j].Input_Update(input_data);
                    if (i == neurons_count-1)
                        neur[i][j].Output_Update_Out();
                    else
                        neur[i][j].Output_Update();
                }
            }

            //softmax
            double sum_softmax = 0.0;
            for (int i = 0; i < NOut; i++)
            {
                sum_softmax += neur[neurons_count - 1][i].Output_value;

            }
            for (int i = 0; i < NOut; i++)
            {
                neur[neurons_count - 1][i].Output_value = neur[neurons_count - 1][i].Output_value / sum_softmax;
            }
            //softmax

            for (int i = 0; i < neur[neurons_count - 1].Count(); i++)
            {
                Out_Put.Add(Math.Round(neur[neurons_count - 1][i].Output_value,15));
            }

            return Out_Put;
        }
    }
    public class In_D
    {
        public string data { get; set; }
        public string ans { get; set; }
    }
     class Neurons
    { 
        public  double[] W_value { get; set; }
        public  double[] dW_value { get; set; }
        public  double Q_value { get; set; }
        public  double dQ_value { get; set; }
        public  double delta { get; set; }
        public  double[] Input_value { get; set; }
        public  double Output_value { get; set; }
        public  double value_count { get; set; }
        public  Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public double ActivationFunction(double value)
        {
            //if (value < 0 ) return 0;
            //if (value > 1 ) return 1.0 / (1.0 + Math.Pow(Math.E, -value));
            //else if (Single.IsInfinity((float)value)) return 1000000;
            //return value;
            //return 2.0 / (1.0 + Math.Pow(Math.E, -value)) - 1;//限制輸出範圍
            return 1.0 / (1.0 + Math.Pow(Math.E, -value));//限制輸出範圍
        }
        public double ActivationFunction_ReLu(double value)
        {
           // if (value < 0 ) return 0.0000001;
            //if (value > 1 ) return 1.0 / (1.0 + Math.Pow(Math.E, -value));
            //else if (Single.IsInfinity((float)value)) return 1000000;
            //return value;
            //return 2.0 / (1.0 + Math.Pow(Math.E, -value)) - 1;//限制輸出範圍
            return 1.0 / (1.0 + Math.Pow(Math.E, -value));//限制輸出範圍
        }
        public  void Clear(int count)
        {
            double rnd_num=0.0;
            value_count = count;
            Input_value = new double[count];
            W_value = new double[count];
            dW_value = new double[count];
            rnd_num = (rnd.NextDouble()-0.5)*2;
            Q_value = rnd_num;
            dQ_value = 0;
            delta = 0;
            for (int i = 0; i < count; i++)
            {
                rnd_num = (rnd.NextDouble()-0.5)*2;
                W_value[i] = rnd_num;
                dW_value[i] = 0;
            }
        }
        public void Input_Update(double[] data)
        {
            for(int i = 0; i < value_count; i++)
            {
                Input_value[i] = data[i];
            }
        }
        public void Output_Update()
        {
            double sum = 0.0;
            for (int i = 0; i < value_count; i++)
                sum += W_value[i] * Input_value[i];
            //Output_value = ActivationFunction_ReLu(sum - Q_value);
            Output_value = ActivationFunction(sum - Q_value);
        }
        public void Output_Update_Out()
        {
            double sum = 0.0;
            for (int i = 0; i < value_count; i++)
                sum += W_value[i] * Input_value[i];
            Output_value = ActivationFunction(sum - Q_value);
            
            //Output_value = ActivationFunction_ReLu(sum - Q_value);
        
        }
        public void delta_Update(double value)
        {
            delta = Output_value * (1.0 - Output_value) * value;
        }
        public void Diff_Weight_Update(double eta , double alpha)
        {
            for(int i = 0; i < value_count; i++)
            {
                dW_value[i] = eta * delta * Input_value[i] + alpha * dW_value[i];
            }
            dQ_value = -eta * delta + alpha * dQ_value;
        }
        public void Weight_Update()
        {
            for(int i = 0; i < value_count; i++)
            {
                W_value[i] += dW_value[i];
                if (W_value[i] > 100)
                {

                }
            }
            Q_value += dQ_value;
        }
    }
}
