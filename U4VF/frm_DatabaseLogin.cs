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
using Microsoft.Win32;
using System.Data.Sql;


namespace U4DF
{
    public partial class db_login_mainform : Form
    {
        public db_login_mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkbx_windauth.Checked = true;


        }
        string lclserver;
        private void btn_login_Click(object sender, EventArgs e)
        {



            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {

                        lclserver = Environment.MachineName;
                        if (instanceName.ToString() == "SQLEXPRESS") { lclserver += @"\" + instanceName; }


                    }
                }
            }


            if (chkbx_windauth.Checked == true)
            {




                string constring = @"Server=" + lclserver + ";Trusted_Connection=Yes";


                try
                {

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = constring;
                    conn.ConnectionString = constring;

                    conn.Open();

                    conn.Close();


                }
                catch (Exception)
                {
                    MessageBox.Show("Connection error no MS SQL Server on this machine  or windows authentication is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frm_searchdb searchfrm = new frm_searchdb(this, constring);
                searchfrm.Show();
                this.Hide();
            }
            else
            {



                string username = txt_username.Text;
                string passwd = txt_password.Text;

                string constring = @"Server=" + lclserver + ";User Id=" + username + ";Password=" + passwd + ";";
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = constring;



                    conn.Open();

                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection error no MS SQL Server on this machine  or check credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                frm_searchdb searchfrm = new frm_searchdb(this, constring);
                searchfrm.Show();
                this.Hide();

            }

        }

        private void chkbx_windauth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_windauth.Checked == true)
            {
                txt_username.Enabled = false;
                txt_password.Enabled = false;
            }
            else
            {
                txt_username.Enabled = true;
                txt_password.Enabled = true;
            }
        }
    }
}
