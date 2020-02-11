using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackPropagationNeuralNetwork
{
    public class BackPropagationNeuralNetworkClass
    {
        /*活化函數*/
        double ActivationFunction(double x)
        {
            double re = 0;
            re = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return re;
        }

        /*學習演算法*/
        public DataSet Learn(DataTable trainDt, int NCycle, int NTrain, double eta, double alpha)
        {
            DataSet reDs = new DataSet();
            #region 設定網路架構變數
            int NInp = trainDt.Rows[0][0].ToString().Split(',').Count();
            int NOut = trainDt.Rows[0][1].ToString().Split(',').Count();
            int NHid = ((NInp + NOut) / 2)+1;
            double[] X = new double[NInp];//輸入神經元
            double[] T = new double[NOut];//目標輸出
            double[] Y = new double[NOut];//真實輸出
            double[] H = new double[NHid];//隱藏神經元

            double[,] W_xh = new double[NInp, NHid];//輸入層與隱藏層之間的加權值
            double[,] W_hy = new double[NHid, NOut];//隱藏層與輸出層之間的加權值
            double[,] dW_xh = new double[NInp, NHid];//輸入層與隱藏層之間的加權值修正量
            double[,] dW_hy = new double[NHid, NOut];//輸入層與隱藏層之間的加權值修正量

            double[] Q_h = new double[NHid];//隱藏層偏權值
            double[] Q_y = new double[NOut];//輸出層偏權值
            double[] dQ_h = new double[NHid];//隱藏層偏權值修正量
            double[] dQ_y = new double[NOut];//輸出層偏權值修正量

            double[] delta_h = new double[NHid];//隱藏層差距量
            double[] delta_y = new double[NOut];//輸出層差距量
            #endregion

            #region 初始化
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            /*將加權值設成亂數，修正量為零*/
            for (int i = 0; i < NInp; i++)
            {
                for (int j = 0; j < NHid; j++)
                {
                    W_xh[i, j] = (rnd.NextDouble() - 0.5);
                    dW_xh[i, j] = 0.0;
                }
            }
            for (int i = 0; i < NHid; i++)
            {
                for (int j = 0; j < NOut; j++)
                {
                    W_hy[i, j] = (rnd.NextDouble() - 0.5);
                    dW_hy[i, j] = 0.0;
                }
            }

            /*設定隱藏層和輸出層初始值*/
            for (int i = 0; i < NHid; i++)
            {
                Q_h[i] = (rnd.NextDouble() - 0.5);
                dQ_h[i] = 0;
                delta_h[i] = 0;
            }
            for (int i = 0; i < NOut; i++)
            {
                Q_y[i] = (rnd.NextDouble() - 0.5);
                dQ_y[i] = 0;
                delta_y[i] = 0;
            }


            #endregion

            #region 開始學習
            /*設定與目標輸出值的平方誤差和的Datatable*/
            DataTable mseDt = new DataTable("mseDt");
            mseDt.Columns.Add("Icycle"); mseDt.Columns.Add("mse");

            /*學習次數迴圈*/
            for (int ICycle = 0; ICycle < NCycle; ICycle++)
            {
                double mse = 0.0;//平方誤差和變數
                /*學習樣本迴圈*/
                for (int ITrain = 0; ITrain < NTrain; ITrain++)
                {
                    /*讀取輸入和理想輸出*/
                    string[] XStr = trainDt.Rows[ITrain][0].ToString().Split(',');
                    for (int i = 0; i < NInp; i++)
                        X[i] = Convert.ToDouble(XStr[i]);
                    string[] TStr = trainDt.Rows[ITrain][1].ToString().Split(',');
                    for (int i = 0; i < NOut; i++)
                        T[i] = Convert.ToDouble(TStr[i]);

                    /*計算隱藏層和輸出層*/
                    for (int i = 0; i < NHid; i++)
                    {
                        double sum = 0.0;
                        for (int j = 0; j < NInp; j++)
                            sum += W_xh[j, i] * X[j] ;
                        H[i] = ActivationFunction(sum - Q_h[i]);
                    }
                    for (int i = 0; i < NOut; i++)
                    {
                        double sum = 0.0;
                        for (int j = 0; j < NHid; j++)
                            sum += W_hy[j, i] * H[j];
                        Y[i] = ActivationFunction(sum - Q_y[i]);
                    }

                    /*計算輸出層和隱藏層差距量*/
                    for (int i = 0; i < NOut; i++)
                        delta_y[i] = Y[i] * (T[i] - Y[i]) * (1.0 - Y[i]);
                    for (int i = 0; i < NHid; i++)
                    {
                        double sum = 0.0;
                        for (int j = 0; j < NOut; j++)
                            sum += W_hy[i, j] * delta_y[j];
                        delta_h[i] = H[i] * (1.0 - H[i]) * sum;
                    }

                    /*計算各層加權值修正量和偏權值修正量*/
                    for (int i = 0; i < NHid; i++)
                    {
                        for (int j = 0; j < NOut; j++)
                            dW_hy[i, j] = eta * delta_y[j] * H[i] + alpha * dW_hy[i, j];
                    }
                    for (int i = 0; i < NOut; i++)
                        dQ_y[i] = -eta * delta_y[i] + alpha * dQ_y[i];
                    for (int i = 0; i < NInp; i++)
                    {
                        for (int j = 0; j < NHid; j++)
                            dW_xh[i, j] = eta * delta_h[j] * X[i] + alpha * dW_xh[i, j];
                    }
                    for (int i = 0; i < NOut; i++)
                        dQ_h[i] = -eta * delta_h[i] + alpha * dQ_h[i];

                    /*更新加權值和偏權值*/
                    for (int i = 0; i < NInp; i++)
                    {
                        for (int j = 0; j < NHid; j++)
                            W_xh[i, j] += dW_xh[i, j];
                    }
                    for (int i = 0; i < NHid; i++)
                    {
                        for (int j = 0; j < NOut; j++)
                            W_hy[i, j] += dW_hy[i, j];
                    }
                    for (int i = 0; i < NHid; i++)
                        Q_h[i] += dQ_h[i];
                    for (int i = 0; i < NOut; i++)
                        Q_y[i] += dQ_y[i];

                    /*計算平方誤差和*/
                    for (int i = 0; i < NOut; i++)
                        mse += (T[i] - Y[i]) * (T[i] - Y[i]);
                }
                DataRow mseDr = mseDt.NewRow();
                mseDr["Icycle"] = ICycle;
                mseDr["mse"] = mse / NTrain;
                mseDt.Rows.Add(mseDr);
            }
            reDs.Tables.Add(mseDt);
            #endregion

            #region 匯出學習後的參數
            DataTable learnDt = new DataTable("learnDt");
            learnDt.Columns.Add("W_xh");
            learnDt.Columns.Add("W_hy");
            learnDt.Columns.Add("Q_h");
            learnDt.Columns.Add("Q_y");

            DataRow dr = learnDt.NewRow();
            for (int i = 0; i < NInp; i++)
            {
                for (int j = 0; j < NHid; j++)
                    dr["W_xh"] += W_xh[i, j] + ",";
                dr["W_xh"] += "\r\n";
            }
            dr["W_xh"] = dr["W_xh"].ToString().Remove(dr["W_xh"].ToString().Count()-3);
            for (int i = 0; i < NHid; i++)
            {
                for (int j = 0; j < NOut; j++)
                    dr["W_hy"] += W_hy[i, j] + ",";
                dr["W_hy"] +=  "\r\n";
            }
            dr["W_hy"] = dr["W_hy"].ToString().Remove(dr["W_hy"].ToString().Count()-3);
            for (int i = 0; i < NHid - 1; i++)
                dr["Q_h"] += Q_h[i] + ",";
            dr["Q_h"] += Q_h[NHid - 1].ToString();
            for (int i = 0; i < NOut - 1; i++)
                dr["Q_y"] += Q_y[i] + ",";
            dr["Q_y"] += Q_y[NOut - 1].ToString();
            learnDt.Rows.Add(dr);
            reDs.Tables.Add(learnDt);
            #endregion
            return reDs;
        }

        /*回想演算法*/
        public double[] Recall(DataTable learnDt,double[] X)
        {
            #region 讀取資料和設定變數
            /*分割資料*/
            string[] Q_hStr = learnDt.Rows[0]["Q_h"].ToString().Split(',');
            string[] Q_yStr = learnDt.Rows[0]["Q_y"].ToString().Split(',');            
            string[] str = learnDt.Rows[0]["W_xh"].ToString().Split('\n');
            string[][] W_xhStr = new string[X.Count()][];
            for (int i = 0;i<X.Count();i++)
                W_xhStr[i] = str[i].Split(',');
            str = learnDt.Rows[0]["W_hy"].ToString().Split('\n');
            string[][] W_hyStr = new string[Q_hStr.Count()][];
            for (int i = 0; i < Q_hStr.Count(); i++)
                W_hyStr[i] = str[i].Split(',');

            /*設定變數*/
            double[] H = new double[Q_hStr.Count()];
            double[] Y = new double[Q_yStr.Count()];
            double[] Q_h = new double[Q_hStr.Count()];
            double[] Q_y = new double[Q_yStr.Count()];
            double[,] W_xh = new double[X.Count(),H.Count()];
            double[,] W_hy = new double[H.Count(),Y.Count()];
            int Ninp = X.Count();
            int NHid = Q_hStr.Count();
            int NOut = Q_yStr.Count();

            /*帶入資料*/
            for (int i = 0; i < H.Count(); i++)
                Q_h[i] = Convert.ToDouble(Q_hStr[i]);
            for (int i = 0; i < Y.Count(); i++)
                Q_y[i] = Convert.ToDouble(Q_yStr[i]);
            for (int i = 0;i<X.Count();i++)
                for (int j = 0; j < H.Count(); j++)
                    W_xh[i, j] = Convert.ToDouble(W_xhStr[i][j]);
            for (int i = 0; i < H.Count(); i++)
                for (int j = 0; j < Y.Count(); j++)
                    W_hy[i, j] = Convert.ToDouble(W_hyStr[i][j]);
            #endregion

            #region 開始回想
            /*計算隱藏層*/
            for (int i = 0;i<NHid;i++)
            {
                double sum = 0.0;
                for (int j = 0; j < Ninp; j++)
                    sum += X[j] * W_xh[j, i];
                H[i] = ActivationFunction(sum - Q_h[i]);                                    
            }
            /*計算輸出層*/
            for (int i = 0;i<NOut;i++)
            {
                double sum = 0.0;
                for (int j = 0; j < NHid; j++)
                    sum += H[j] * W_hy[j, i];
                Y[i] = ActivationFunction(sum - Q_y[i]);
            }
            #endregion

            return Y;
        }

    }
}
