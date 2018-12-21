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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "select case when 是否停车 = 0 then '否' else '是' end as 是否停车 from Table_2";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            //MessageBox.Show(string.Format("数据刷新成功!"));
            
            conn.Close();
        }
   

        private void Form6_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
