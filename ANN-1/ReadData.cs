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
        public DataTable txtToDatatable(string path)
        {
            StreamReader sr = new StreamReader(Path.GetFullPath(path));
            string s = sr.ReadToEnd();
            s = s.Replace("\r\n","。");
            string[] data = s.Split('。');
            DataTable dt = new DataTable();
            dt.Columns.Add("Input");
            dt.Columns.Add("Ans");
            for (int i = 0; i < data.Count(); i++)
            {
                DataRow dr = dt.NewRow();
                string[] nd = data[i].Split('/');
                dr[0] = nd[0];
                dr[1] = nd[1];
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
