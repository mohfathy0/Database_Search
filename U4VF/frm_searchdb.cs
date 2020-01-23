using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace U4DF
{
    public partial class frm_searchdb : Form
    {
        Form loginform;
        string constring;
        DataTable dt_result = new DataTable();
        public frm_searchdb(Form oldform, string _constring)
        {
            InitializeComponent();
            loginform = oldform;
            constring = _constring;
        }


        private void frm_searchdb_Load(object sender, EventArgs e)
        {
            string dbquery = "SELECT name FROM sys.databases WHERE name != 'master' order by name";
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = dbquery;
            DataTable cmb_dt_dbname = new DataTable();
            SqlDataAdapter adap_dbname = new SqlDataAdapter(cmd);
            adap_dbname.Fill(cmb_dt_dbname);

            cmb_db.DisplayMember = "name";
            cmb_db.ValueMember = "name";
            cmb_db.DataSource = cmb_dt_dbname;
            




            DataTable dt_cmbbx = new DataTable();
            dt_cmbbx.Columns.Add("Operator");
            dt_cmbbx.Columns.Add("Display");
            dt_cmbbx.Columns.Add("ID");


            dt_cmbbx.Rows.Add("LIKE","Contain","General");
            dt_cmbbx.Rows.Add("=", "Equal to","General");
            dt_cmbbx.Rows.Add("<>", "Not equal to","General");
            dt_cmbbx.Rows.Add(">","Greater than","Numbers");
            dt_cmbbx.Rows.Add("<","Less than", "Numbers");
            dt_cmbbx.Rows.Add(">=","Greater than or equal to", "Numbers");
            dt_cmbbx.Rows.Add("<=","Less than or equal to", "Numbers");


            cmb_srchcrai.DisplayMember = "Display";
            cmb_srchcrai.ValueMember = "Operator";
            cmb_srchcrai.DataSource = dt_cmbbx;
            
        }

        private void frm_searchdb_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Show();

        }
        frm_Searching frm;
        private void btn_search_Click(object sender, EventArgs e)
        {
            constring += ";Database=" + cmb_db.SelectedValue.ToString() + ";";

            ;
            //int Number;
            if (txt_searchvalue.Text == "")
            {
                MessageBox.Show("Please enter value to search for !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //else if (!int.TryParse(txt_searchvalue.Text.ToString(),out Number)&&(cmb_srchcrai.ValueMember!=(">")|| cmb_srchcrai.ValueMember != ("<")|| cmb_srchcrai.ValueMember != (">=")|| cmb_srchcrai.ValueMember != ("<=")))
            //{
            //    MessageBox.Show("Value need to be a number");
            //    return;
            //}
            else
            {
                string sqloprator = cmb_srchcrai.SelectedValue.ToString();
               
                string tblquery = "select name from sys.tables order by name";
                SqlConnection conn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = tblquery;
                DataTable dt_tablenames = new DataTable();
                SqlDataAdapter adap_tablenames = new SqlDataAdapter(cmd);
                adap_tablenames.Fill(dt_tablenames);
                

                if (Application.OpenForms.OfType<frm_Searching>().Count() > 0)
                {
                    frm.BringToFront();
                    return;
                }
                else
                {
                    frm = new frm_Searching(constring, dt_tablenames, txt_searchvalue.Text.ToString(), dt_result, dataGridView1, this, sqloprator);
                    frm.ShowDialog();
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentRow.Index;
            
            string resultdataqry = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            

            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = resultdataqry;
            DataTable dt_results = new DataTable();
            SqlDataAdapter adap_tablenames = new SqlDataAdapter(cmd);
            adap_tablenames.Fill(dt_results);
            frm_result frm = new frm_result(dt_results);
            frm.ShowDialog();


        }
    }
}