using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4DF
{
    public partial class frm_result : Form
    {
        DataTable dt_results;
        public frm_result(DataTable _dt_results)
        {
            InitializeComponent();
            dt_results = _dt_results;
        }

        private void frm_result_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt_results;
        }
    }
}
