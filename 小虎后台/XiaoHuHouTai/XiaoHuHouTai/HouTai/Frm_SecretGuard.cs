using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XiaoHuHouTai;

namespace XiaoHu
{
    public partial class Frm_SecretGuard : Form
    {
        public Frm_SecretGuard()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void Frm_SecretGuard_Load(object sender, EventArgs e)
        {
            //获取账号
            lblUser.Text = Common.User;
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            //获取用户输入的密保信息
            string SecretGuard1 = txtSecretGuard1.Text;
            string SecretGuard2 = txtSecretGuard2.Text;
            string SecretGuard3 = txtSecretGuard3.Text;
            string Answer1 = txtAnswer1.Text;
            string Answer2 = txtAnswer2.Text;
            string Answer3 = txtAnswer3.Text;
            string id = Common.ID;
            //判断非空
            if (SecretGuard1 == "" || SecretGuard2 == "" || SecretGuard3 == "" || Answer1 == "" || Answer2 == "" || Answer3 == "" || id=="" )
            {
                MessageBox.Show("请输入必填信息！");
                return;
            }
            //新增信息
            string sql = string.Format(@"Insert Encrypted (CustomerID,EncryptedQuestion1,EncryptedAnswer1,EncryptedQuestion2,EncryptedAnswer2,EncryptedQuestion3,EncryptedAnswer3)
                                       values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, SecretGuard1, Answer1, SecretGuard2, Answer2, SecretGuard3, Answer3);
            //调用DBHelper的ExecuteNonQuery
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("密保设置成功！");
            }
            this.Close();
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
    }
}
