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
using XiaoHuHouTai;

namespace XiaoHu
{
    public partial class Frm_Sign : Form
    {
        public Frm_Sign()
        {
            InitializeComponent();
        }

        private void lblPwd_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //获取用户输入的用户名和密码
            string User = txtUser.Text;
            string Pwd = txtPwd.Text;
            //判断用户名和密码是否为空
            if (User.Equals("") || Pwd.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                    //创建查询语句，判断是否输入正确
                    string sql1 = "Select * from Customer where CustomerUser='" + User + "'" + " and CustomerPwd='" + Pwd + "'" + " and Admin='是'";//查找用户sql语句
                    DataTable dt1 = new DataTable();
                    dt1 = DBHelper.GetDataTable(sql1);
                    int count1 = dt1.Rows.Count;
                    //从结果中找到
                    if (count1 > 0)
                    {
                        //输入正确则进入管理员主页
                        Frm_Admin frm_Admin = new Frm_Admin();
                        this.Hide();
                        frm_Admin.Show();
                    }
                    else
                    {
                        //创建查询语句，判断是否输入正确
                        string sql2= "Select * from Customer where CustomerUser='" + User + "'" + " and CustomerPwd='" + Pwd + "'" + " and Admin='否'";//查找用户sql语句
                        DataTable dt2 = new DataTable();
                        dt2 = DBHelper.GetDataTable(sql2);
                        int count2 = dt2.Rows.Count;
                        //从结果中找到
                        if (count2 > 0)
                        {
                            MessageBox.Show("该用户不是管理员！", "提示");
                        }
                        //结果中没有
                        else
                        {
                            MessageBox.Show("账号或密码错误！", "提示");
                            return;
                        }
                    }
                
            }
        }
        //点击进入改密界面
        private void lklblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ChangeSecret frm_ChangeSecret = new Frm_ChangeSecret();
            frm_ChangeSecret.Show();
        }
        //点击按钮显示隐藏密码
        private void ckbDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == '*')
            {
                ckbDisplay.Text = "隐藏密码";
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                txtPwd.PasswordChar = '*';
                ckbDisplay.Text = "显示密码";
            }
        }

        //点击退出登录
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }
        //设置可拖动窗体
        private Point mpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }

        private void Frm_Sign_Load(object sender, EventArgs e)
        {

        }
    }
}
