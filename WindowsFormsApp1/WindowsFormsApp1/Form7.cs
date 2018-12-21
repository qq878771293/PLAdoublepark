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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            function();
        }
        public void function()
        {
            string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void infoquery_Click(object sender, EventArgs e)
        {
         
            if (comboBox3.Text=="车牌号"&& textBox1.Text != "")
            {
                
                string strname = textBox1.Text;
                string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                string commandstr = "SELECT * FROM TABLE_1 where 车牌号 like '%" + strname + "%'";
                //MessageBox.Show(commandstr);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                //  MessageBox.Show(string.Format("数据刷新成功!"));
                conn.Close();
                textBox1.Text = "";
            }else if(comboBox3.Text=="车牌号"&&textBox1.Text=="")
            {
                    MessageBox.Show("请输入正确的查询条件！");
            }

            if (comboBox3.Text == "车辆类型" && comboBox1.Text != "")
            {
               
                string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                string commandstr = "SELECT * FROM TABLE_1 where 车辆类型 ='" + comboBox1.Text + "'";
               // MessageBox.Show(commandstr);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                //  MessageBox.Show(string.Format("数据刷新成功!"));
                conn.Close();
                comboBox1.Text = "";
            }
            else if (comboBox3.Text == "车辆类型" && comboBox1.Text == "")
            {
                MessageBox.Show("请输入正确的查询条件！");
            }
            if (comboBox3.Text=="停放类型" && comboBox2.Text != "")
            {
                string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                string commandstr = "select * from TABLE_1 where 停放类型 like '%" + comboBox2.Text + "%'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                //  MessageBox.Show(string.Format("数据刷新成功!"));
                conn.Close();
            }
            else if (comboBox3.Text == "停放类型" && comboBox2.Text == "")
            {
                MessageBox.Show("请输入正确的查询条件！");
            }
            if (comboBox3.Text == "日期" && dateTimePicker1.Text != "")
            {
                string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
            
                string commandstr = "select * from TABLE_1 where 进场时间 >'" + dateTimePicker1.Text + "'and 进场时间 <'"+dateTimePicker2.Text+"'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                //  MessageBox.Show(string.Format("数据刷新成功!"));
                conn.Close();
            }
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            label3.Visible = false;
            comboBox2.Visible = false;
            label4.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text == "车牌号")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Visible = false;
                comboBox1.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                label4.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (comboBox3.Text == "车辆类型")
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = true;
                comboBox1.Visible = true;
                label3.Visible = false;
                comboBox2.Visible = false;
                label4.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (comboBox3.Text == "停放类型")
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label3.Visible = true;
                comboBox2.Visible = true;
                label4.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (comboBox3.Text == "日期")
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                label4.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            string strname = dataGridView1.SelectedCells[0].Value.ToString();
            string constr = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "DELETE FROM TABLE_1 where 车牌号='" + strname + "';SELECT * FROM TABLE_1";
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
