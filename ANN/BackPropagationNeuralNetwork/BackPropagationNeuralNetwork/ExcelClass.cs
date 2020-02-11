using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;

namespace BackPropagationNeuralNetwork
{
    public class ExcelClass
    {
        public static void toExcelNew(string path, DataTable dt)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook book = app.Workbooks.Add();
            Excel.Worksheet sheet = book.Worksheets[1];
            int c = 0, r = 0;
            string[,] sss = new string[dt.Rows.Count, dt.Columns.Count];
            foreach (DataRow dr in dt.Rows)
            {
                c = 0;
                foreach (DataColumn col in dt.Columns)
                    sss[r, c++] = dr[col.ColumnName].ToString();
                r++;
            }
            sheet.Range[sheet.Cells[1, 1], sheet.Cells[dt.Rows.Count, dt.Columns.Count]].Value2 = sss;
            book.SaveAs(path);
            app.Quit();
        }

        public static DataSet ExcelToTable(string path)
        {
            DataSet ds = new DataSet();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+path+ ";Extended Properties = 'Excel 12.0 xml;HDR = yes'");
            con.Open();
            DataRow[] sheet = con.GetSchema("Tables").Select();
            OleDbDataAdapter sda;
            foreach (DataRow sheetDr in sheet)
            {
                DataTable dt = new DataTable();
                dt.TableName = sheetDr["TABLE_NAME"].ToString().Replace("$","").Replace("'","");
                sda = new OleDbDataAdapter("Select * From ["+dt.TableName + "$]",con);
                sda.Fill(dt);
                ds.Tables.Add(dt);
            }
            con.Close();
            return ds;
        }

        public static DataTable CSVToTable(string path)
        {
            OleDbConnection connection = new OleDbConnection(string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""text;HDR=Yes;FMT=Delimited"";",Path.GetDirectoryName(path) ));
            OleDbCommand command = new OleDbCommand("SELECT * FROM " + Path.GetFileName(path), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
