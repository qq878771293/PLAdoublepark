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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Function();
        }
        public void Function()
        {
            string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            //  MessageBox.Show(string.Format("数据刷新成功!"));
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                int count = dataGridView1.Rows.Count;
                if (count <= 100)
                {
                    string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
                    SqlConnection conn = new SqlConnection(constr);
                    string commandstr = "INSERT into TABLE_1 (车牌号,车辆类型,停放类型,进场时间) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "');SELECT * FROM TABLE_1";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Open();
                    //MessageBox.Show(string.Format("数据刷新成功!"));
                    conn.Close();
                    this.textBox1.Text = "";
                    this.comboBox1.Text = "";
                    //this.ttime.Text = "";
                    this.comboBox2.Text = "";
                    DialogResult ddd = MessageBox.Show("录入成功，是否进入场内车辆查看界面？", "提示", MessageBoxButtons.YesNo);
                    if (ddd == DialogResult.Yes)
                    {
                        Form4 form = new Form4();
                        form.Show();
                        this.Hide();
                    }
                  
                }
                else
                    MessageBox.Show(string.Format("车位已满!"));
            }
            else
                MessageBox.Show(string.Format("请填写完整信息!"));
        }

        private void carout_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void parkquery_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void camera_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult ddd = MessageBox.Show("是否选择退出程序", "提示", MessageBoxButtons.YesNo);
            if (ddd == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
