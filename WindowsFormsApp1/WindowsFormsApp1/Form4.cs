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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            function();
        }
        public void function()
        {
            string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT 车牌号 FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            //MessageBox.Show(string.Format("数据刷新成功!"));
            conn.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strname = dataGridView1.SelectedCells[0].Value.ToString();
            string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            // string commandstr = "SELECT 车牌号 FROM TABLE_1";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM TABLE_1 WHERE 车牌号='" + strname + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.ttype.Text = dr.GetString(2);
                this.tcartype.Text = dr.GetString(1);
                this.ttime.Text = dr.GetDateTime(3).ToString();
                string time1 = dr.GetDateTime(3).ToString();
                DateTime t1 = DateTime.Parse(time1);
                DateTime t2 = DateTime.Now;
                System.TimeSpan ts = t2 - t1;
                int timeh = ts.Hours;
                int timem = ts.Minutes;
                int timed = ts.Days;
                 string timeh1 =Convert.ToString(timeh);
                string timeh2 = Convert.ToString(timem);
                this.ttime.Text = ("" + timed + "天" + timeh + "时" + timem + "分");
            }
            dr.Close(); ;
        
            //MessageBox.Show(string.Format("数据刷新成功!"));
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void carout()
        {
         
        }
        private void bout_Click(object sender, EventArgs e)
        {
            string plate = "";
            string type3 = "";
            string cartype = "";
            string time1 = "";
            string time2 = "";
            {
                string strname = dataGridView1.SelectedCells[0].Value.ToString();
                string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                // string commandstr = "SELECT 车牌号 FROM TABLE_1";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM TABLE_1 WHERE 车牌号='" + strname + "'";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    plate = dr.GetString(0);

                    type3 = dr.GetString(2);
                    ttype.Text = type3;
                    cartype = dr.GetString(1);
                    tcartype.Text = cartype;

                    time1 = dr.GetDateTime(3).ToString();
                    ttime.Text = time1;
                    DateTime t1 = DateTime.Parse(time1);
                    DateTime t2 = DateTime.Now;
                    TimeSpan ts1 = new TimeSpan(t1.Ticks);
                    TimeSpan ts2 = new TimeSpan(t2.Ticks);
                    TimeSpan ts = ts2.Subtract(ts1).Duration();
                    string spanTime = ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒";
                    ttime.Text = spanTime;
                    time2 = Convert.ToString(t2);

                }
                dr.Close();
                conn.Close();
            }

            DialogResult ddd = MessageBox.Show("是否确认车牌号:"+plate+"  车辆类型:"+cartype+"  停放类型:"+type3+"  停车时长:"+ttime.Text+"出场？", "提示", MessageBoxButtons.YesNo);
            if (ddd == DialogResult.Yes)
            {
                if (tcartype.Text != "")
                {
                    string constr1 = "server=172.23.29.89;Database=停车管理bak;integrated security=SSPI";
                    SqlConnection conn1 = new SqlConnection(constr1);
                    string commandstr1 = "INSERT INTO Table_1 (车牌号,停放类型,车辆类型,进场时间,出场时间) values('" + plate + "','" + type3 + "','" + cartype + "','" + time1 + "','" + time2 + "');";
                    //string commandstr1 = "INSERT INTO Table_1 (车牌号) values('" + tprice.Text + "');";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(commandstr1, conn1);
                    conn1.Open();
                    da.Fill(dt);
                    //dataGridView1.DataSource = dt;

                    //MessageBox.Show(string.Format("'" + plate + "','" + type3 + "','" + cartype + "','" + time1 + "','" + time2 + "'"));
                    conn1.Close();
                }
                if (tcartype.Text != "")
                {

                    string strname = dataGridView1.SelectedCells[0].Value.ToString();
                    string constr = "server=172.23.29.89;Database=停车管理;integrated security=SSPI";
                    SqlConnection conn = new SqlConnection(constr);
                    string commandstr = "DELETE FROM TABLE_1 where 车牌号='" + strname + "';SELECT 车牌号 FROM TABLE_1";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();


                }
            }
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void historyquery_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void fee_Click(object sender, EventArgs e)
        {

        }
    }
    }

