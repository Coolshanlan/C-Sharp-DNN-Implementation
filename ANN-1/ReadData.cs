using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace BackPropagationNeuralNetwork
{
    class ReadData
    {
        Random rnd = new Random();
        public DataTable CSVToDatatable(string path)
        {
            //OleDbConnection connection = new OleDbConnection(string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""text;HDR=Yes;FMT=Delimited"";", Path.GetDirectoryName(path)));
            //OleDbCommand command = new OleDbCommand("SELECT * FROM " + Path.GetFileName(path), connection);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            OleDbConnection connection= new OleDbConnection( string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""text;HDR=Yes;FMT=Delimited"";", Path.GetDirectoryName(path)));
            OleDbCommand command = new OleDbCommand("SELECT * FROM " + Path.GetFileName(path), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public string OneHot(string code,int MaxO)
        {
            string onehotcode = "";
            for(int i = 0; i <MaxO; i++)
            {
                if  (i == Convert.ToInt16(code) - 1){
                    onehotcode += "1";
                }
                else
                {
                    onehotcode += "0";
                }
                if (i != MaxO-1)
                {
                    onehotcode += ",";
                }
            }
            return onehotcode;
        }
        public DataTable[] txtToDatatable(string path)
        {
            StreamReader sr = new StreamReader(Path.GetFullPath(path));
            string s = sr.ReadToEnd();
            s = s.Replace("\r\n","。");
            List<string> data = s.Split('。').ToList();
            for(int i = 0; i < data.Count; i++)
            {
                if(data[i] == "")
                {
                    data.RemoveAt(i);
                    i--;
                }
            }
            data = data.ToArray().OrderBy(x => rnd.Next()).ToList();
            List<string> val_data = new List<string>();
            int low_val_num = Math.Max(data.Count() / 3, 1);
            for(int tmp =0;tmp< low_val_num; tmp++)
            {
                val_data.Add(data[0]);
                data.RemoveAt(0);
            }

            DataTable dt = new DataTable();
            DataTable val_dt = new DataTable();
            dt.Columns.Add("Input");
            dt.Columns.Add("Ans");
            val_dt.Columns.Add("Input");
            val_dt.Columns.Add("Ans");
            int Maxoutput = 0;
            bool zerotrue = false;
            for (int i = 0; i < data.Count(); i++)
            {
                DataRow dr = dt.NewRow();
                //string[] nd = data[i].Split(' ');
                dr[0] = data[i].Substring(0, data[i].Length - 2).Replace(' ',',');
                dr[1] = data[i].Substring(data[i].Length - 1,1 );
                if(dr[1].ToString() == "0")
                {
                    zerotrue = true;
                }
                if (Maxoutput < Convert.ToInt16(dr[1].ToString())){
                    Maxoutput = Convert.ToInt16(dr[1].ToString());
                }
                dt.Rows.Add(dr);
            }


            for (int i = 0; i < val_data.Count(); i++)
            {
                DataRow dr = val_dt.NewRow();
                dr[0] = val_data[i].Substring(0, val_data[i].Length - 2).Replace(' ', ',');
                dr[1] = val_data[i].Substring(val_data[i].Length - 1, 1);
                if (dr[1] == "0")
                {
                    zerotrue = true;
                }
                if (Maxoutput < Convert.ToInt16(dr[1].ToString()))
                {
                    Maxoutput = Convert.ToInt16(dr[1].ToString());
                }
                val_dt.Rows.Add(dr);
            }
            if (zerotrue)
            {
                Maxoutput += 1;
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (zerotrue)
                {
                    dr[1] = OneHot((Convert.ToInt32(dr[1])+1).ToString(), Maxoutput);
                }
                else
                {
                    dr[1] = OneHot((Convert.ToInt32(dr[1])).ToString(), Maxoutput);
                }
                
            }
            foreach (DataRow dr in val_dt.Rows)
            {
                if (zerotrue)
                {
                    dr[1] = OneHot((Convert.ToInt32(dr[1]) + 1).ToString(), Maxoutput);
                }
                else
                {
                    dr[1] = OneHot((Convert.ToInt32(dr[1])).ToString(), Maxoutput);
                }
            }
            DataTable[] tmp_rtn_Datatable = { dt, val_dt };
            return tmp_rtn_Datatable;
        }
    }
}
