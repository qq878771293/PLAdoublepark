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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}




		//按登录按钮，核对用户密码
		private void Login(object sender, EventArgs e)
		{
            //获取文本框中的值
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (username.Equals("") || password.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else//用户名或密码不为空
            {
                //到数据库中验证
                string selectSql = "select * from tb_user where username='" + username + "' and pwd='" + password + "'";
                SqlHelp sqlHelper = new SqlHelp();
             
                int count = sqlHelper.SqlServerRecordCount(selectSql);//返回符合的结果数量
         
                if (count > 0)//如果信息>0则说明匹配成功
                {
                    MessageBox.Show("管理员"+textBox1.Text+"登陆成功！");
                    //跳转到主页面
                    Form3 form = new Form3();//创建一个新页面
                    form.Show();//显示新页面
                    this.Hide();//隐藏当前页面

                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }




        }

		private void Register(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text == "")
				{
					MessageBox.Show("用户名不能为空");
				}
				else
				{
					if (textBox2.Text == "")
					{
						MessageBox.Show("密码不能为空!");
					}
					else
					{

						string user = textBox1.Text;
						string pwd = textBox2.Text;
						SqlConnection conn = new SqlConnection("server=172.23.29.89;database=parking;user=sa;pwd=123");////创建数据库连接类的对象
						conn.Open();
						//执行con对象的函数，返回一个SqlCommand类型的对象
						SqlCommand cmd = conn.CreateCommand();
						cmd.CommandText = "insert into tb_user values('" + user + "','" + pwd + "')";
						//增删改用ExecuteNonQuery，会返回一个整型数字
						int count = cmd.ExecuteNonQuery();
                       
						if (count > 0)
						{
							MessageBox.Show("添加用户成功");
						}
						else
						{
							MessageBox.Show("添加用户失败");
						}
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("异常错误" + ex);
			}
		}

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
			
	
	

