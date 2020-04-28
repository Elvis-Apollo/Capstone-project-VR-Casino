using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAdmin
{
    public partial class UserResults : Form
    {
        DataTable dt;
        public UserResults()
        {
            InitializeComponent();
            dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Columns.Add("env", typeof(String));
            dt.Columns.Add("earnings", typeof(int));
            dt.Columns.Add("start_time", typeof(int));
            dt.Columns.Add("end_time", typeof(int));
            dt.Columns.Add("round", typeof(int));
        }

       

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
