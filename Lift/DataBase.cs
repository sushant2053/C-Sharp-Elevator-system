using System.Data;
using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LiftSystem
{
    internal class DataBase
    {
        static string directc = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = LiftDb.accdb";
        static OleDbConnection conn = new OleDbConnection(directc);
        static string query = "SELECT * FROM LiftTable;";
        static OleDbCommand dbcommand = new OleDbCommand(query, conn);

        public void Insert(string data)
        {
            try
            {
                OleDbDataAdapter oda = new OleDbDataAdapter(dbcommand);
                DataSet ds = new DataSet();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
                oda.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.NewRow();
                dr["Date&Time"] = DateTime.Now.ToString();
                dr["Details"] = data;
                dt.Rows.Add(dr);
                DataSet dsl = ds.GetChanges();
                oda.Update(dsl);
                dt.AcceptChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public DataSet Show()
        {
            OleDbDataAdapter oda = new OleDbDataAdapter(dbcommand);
            DataSet datas = new DataSet();
            oda.Fill(datas);
            return datas;
        }
    }
}