using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4DF
{
    public partial class frm_Searching : Form
    {
        int counttables;
        string constring;
        string tablename;
        string valuetofind;
        string sqloperator;
        DataGridView dgv_frm2;
        DataTable dt_tablenames;
        Form frm_Searchdb;

        public frm_Searching(string _constring, DataTable _dt_tablenames, string _valuetofind, DataTable _dt_result, DataGridView _dgv_frm2, Form _frm_searchdb, string _sqloperator)
        {
            InitializeComponent();
            constring = _constring;
            dt_tablenames = _dt_tablenames;
            counttables = _dt_tablenames.Rows.Count;
            valuetofind = _valuetofind;
            dgv_frm2 = _dgv_frm2;
            frm_Searchdb = _frm_searchdb;
            sqloperator = _sqloperator;
        }

        private void frm_Searching_Load(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();


            }
            else
            {
                label2.Text = "Please wait ...";
            }
        }
        DataTable dt_result = new DataTable();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            dt_result.Columns.Add("Count rows");
            dt_result.Columns.Add("Table name");
            dt_result.Columns.Add("Column name");
            dt_result.Columns.Add("Select statment");



            int onepercent = (counttables / 100);
            int i = 0;
            int x = 0;
            foreach (DataRow tbl in dt_tablenames.Rows)
            {
                tablename = tbl[0].ToString();
                string columnsquery = "select COLUMN_NAME from  information_schema.columns where TABLE_NAME = '" + tablename + "' order by COLUMN_NAME";
                SqlConnection conn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = columnsquery;
                DataTable dt_columnnames = new DataTable();
                SqlDataAdapter adap_columnnames = new SqlDataAdapter(cmd);
                adap_columnnames.Fill(dt_columnnames);
                foreach (DataRow clm in dt_columnnames.Rows)
                {

                    string clmname = clm[0].ToString();

                    string selectquery = "SELECT * FROM  [dbo].[" + tablename + "] WHERE [" + clmname + "] LIKE N'%" + valuetofind.ToString() + "%'";

                    // test here

                    switch (sqloperator)
                    {
                        case "LIKE":

                            selectquery = "SELECT * FROM  [dbo].[" + tablename + "] WHERE [" + clmname + "] " + sqloperator + " N'%" + valuetofind.ToString() + "%'";

                            break;

                        default:


                            selectquery = "SELECT * FROM  [dbo].[" + tablename + "] WHERE [" + clmname + "] " + sqloperator + " N'" + valuetofind.ToString() + "'";

                            break;
                    }

                    //end here
                    MessageBox.Show(selectquery);






                    
                    SqlConnection confin = new SqlConnection(constring);
                    SqlCommand cmdfind = new SqlCommand();
                    cmdfind.Connection = confin;
                    cmdfind.CommandText = selectquery;
                    DataTable dt_find = new DataTable();
                    SqlDataAdapter adap_find = new SqlDataAdapter(cmdfind);
                    adap_find.Fill(dt_find);
                    
                    if (dt_find.Rows.Count > 0)
                    {

                        dt_result.Rows.Add(dt_find.Rows.Count.ToString(), tablename, clmname, selectquery);


                    }


                }
                if (x >= onepercent)
                {
                    i++;
                    x = 0;
                }
                else
                {
                    x++;
                }

                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            e.Result = dt_result;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.ProgressPercentage.ToString() + "%   Currently searching in table name : " + tablename;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "Progress cancelled";
                dgv_frm2.DataSource = dt_result;

                dgv_frm2.AutoResizeColumns();
                dgv_frm2.Refresh();
            }
            else if (e.Error != null)
            {
                label1.Text = e.Error.Message;
            }
            else
            {
                label1.Text = "Completed";
                if (dt_result.Rows.Count == 0)
                {
                    MessageBox.Show("nothing found ");
                }
                dgv_frm2.DataSource = dt_result;

                dgv_frm2.AutoResizeColumns();
                dgv_frm2.Refresh();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();

            }
            else
            {
                label2.Text = "Please wait ...";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                this.Close();
            }
            else
            {
                label1.Text = "Nothing to cancel";
            }
        }

        private void frm_Searching_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                dgv_frm2.DataSource = dt_result;

                dgv_frm2.AutoResizeColumns();
                dgv_frm2.Refresh();
            }

        }
        int isec = 0;
        int imin = 0;
        private void timercounter_Tick(object sender, EventArgs e)
        {
            isec++;

            if (isec >= 60)
            {
                isec = 0;
                imin++;
                label2.Text = imin.ToString() + "Minutes " + isec.ToString() + " Seconds";
            }
            else
            {
                label2.Text = imin.ToString() + " Minutes " + isec.ToString() + " Seconds";
            }

        }
    }
}

