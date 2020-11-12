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
    public partial class Frm_ChangeSecret : Form
    {
        public Frm_ChangeSecret()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //获取输入的账号
            string CustomerUser = txtCustomerUser.Text;
            //获取该账号的ID
            string sql1 = string.Format("select * from Customer where CustomerUser = '{0}'", CustomerUser);
            DataTable dt1 = DBHelper.GetDataTable(sql1);
            int CustomerId = int.Parse(dt1.Rows[0][0].ToString());
            //从数据库获取密保
            string sql2 = string.Format("select * from Encrypted where CustomerID={0}", CustomerId);
            DataTable dt2 = DBHelper.GetDataTable(sql2);
            string SecretGuard1 = dt2.Rows[0][1].ToString();
            string Answer1 = dt2.Rows[0][2].ToString();
            string SecretGuard2 = dt2.Rows[0][3].ToString();
            string Answer2 = dt2.Rows[0][4].ToString();
            string SecretGuard3 = dt2.Rows[0][5].ToString();
            string Answer3 = dt2.Rows[0][6].ToString();
            //获取用户输入
            string User = txtCustomerUser.Text;
            string Guard1 = txtSecretGuard1.Text;
            string Daan1 = txtAnswer1.Text;
            string Guard2 = txtSecretGuard2.Text;
            string Daan2 = txtAnswer2.Text;
            string Guard3 = txtSecretGuard3.Text;
            string Daan3 = txtAnswer3.Text;
            string Mima1 = txtPwd.Text;
            string Mima2 = txtConfirm.Text;
            //判断是否输入完整
            if (User == ""||Guard1==""||Daan1==""||Guard2==""||Daan2==""||Guard3==""||Daan3==""||Mima1==""||Mima2=="")
            {
                MessageBox.Show("请填写完整信息","提示");
                return;
            }
            else
            {
                //创建SQL语句
                string sql3 = "Select * from Customer where CustomerUser='" + CustomerUser + "'";//查找用户sql语句
                //从结果中找到该账号
                DataTable dt3 = new DataTable();
                dt3 = DBHelper.GetDataTable(sql3);
                int count1 = dt3.Rows.Count;
                //从结果中找到
                if (count1 > 0)
                {
                    //判断密保是否正确
                    if (txtSecretGuard1.Text == SecretGuard1 && txtSecretGuard2.Text == SecretGuard2 && txtSecretGuard3.Text == SecretGuard3 && txtAnswer1.Text == Answer1 && txtAnswer2.Text == Answer2 && txtAnswer3.Text == Answer3)
                    {
                        //判断两次密码输入是否相同
                        string Pwd = txtPwd.Text;
                        string Confirm = txtConfirm.Text;
                        if (Pwd != Confirm)
                        {
                            MessageBox.Show("两次密码输入不一致!请重新输入");
                            txtPwd.Text = "";
                            txtConfirm.Text = "";
                            return;
                        }
                        string sql4 = string.Format(@"Update Customer Set CustomerPwd='{0}' Where CustomerUser='{1}'", Pwd, CustomerUser);
                        if (DBHelper.ExecuteNonQuery(sql4))
                        {
                            DialogResult result = MessageBox.Show("密码修改成功！点击确定返回登录界面进行登录", "提示", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该账号密保错误!请重新输入");
                        txtSecretGuard1.Text = "";
                        txtAnswer1.Text = "";
                        txtSecretGuard2.Text = "";
                        txtAnswer2.Text = "";
                        txtSecretGuard3.Text = "";
                        txtAnswer3.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("没有该账号!请重新输入");
                    txtCustomerUser.Text = "";
                    return;
                }
            }
        }
        //点击退出程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXS1_Click(object sender, EventArgs e)
        {
            //设置显示和隐藏密码
            if (txtPwd.PasswordChar == '*')
            {
                btnXS1.Text = "隐";
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                txtPwd.PasswordChar = '*';
                btnXS1.Text = "显";
            }
        }

        private void btnXS2_Click(object sender, EventArgs e)
        {
            // 设置显示和隐藏密码
            if (txtConfirm.PasswordChar == '*')
            {
                btnXS2.Text = "隐";
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtConfirm.PasswordChar = '*';
                btnXS2.Text = "显";
            }
        }
        //设置可拖动窗体
        private Point mpoint;

        private void plTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }
        }

        private void plTop_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }
    }
}
