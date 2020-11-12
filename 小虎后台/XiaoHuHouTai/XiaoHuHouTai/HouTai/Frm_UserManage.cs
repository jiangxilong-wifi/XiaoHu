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
using System.IO;

namespace XiaoHu
{
    public partial class Frm_UserManage : Form
    {
        public Frm_UserManage()
        {
            InitializeComponent();
        }
        //创建刷新方法
        private void SelectInfo()
        {
            //查询语句
            string sql = "Select * From Customer";
            //调用DBHelper的GetDataTable
            DataTable dt = DBHelper.GetDataTable(sql);
            //设置DataGridView的数据源为dt
            dgv.DataSource = dt;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //获取所有的填入的内容
            string CustomerName = txtCustomerName.Text;
            string CustomerUser = txtCustomerUser.Text;
            string CustomerPwd = txtCustomerPwd.Text;
            string Tel = txtCustomerTel.Text;
            //获取选择的头像链接
            string ImageString =img;
            string Balance = txtBalance.Text;
            string Sex = "";
            if (rdoMan.Checked) Sex = rdoMan.Text;
            else Sex = rdoWoman.Text;
            string Admin = "";
            if (rdoYesAdmin.Checked) Admin = rdoYesAdmin.Text;
            else Admin = rdoNoAdmin.Text;
            string VIP = "";
            if (rdoYesVIP.Checked) VIP = rdoYesVIP.Text;
            else VIP = rdoNoVIP.Text;

            //判断非空
            if (CustomerName.Equals("") || CustomerUser.Equals("") || CustomerPwd.Equals("") || Tel.Equals("") || ImageString.Equals("") || Balance.Equals(""))
            {
                MessageBox.Show("请将信息填写完整！", "提示");
            }
            else
            {
                if (txtCustomerUser.Text.Length < 3 || txtCustomerUser.Text.Length > 12 || txtCustomerPwd.Text.Length < 6 || txtCustomerPwd.Text.Length > 16)
                {
                    MessageBox.Show("用户账号为3到12位，密码为6到16位", "提示");
                }
                else
                {
                    //创建SQL语句
                    string sql1 = "Select * from Customer where CustomerUser='" + CustomerUser + "'";//查找用户sql语句
                    DataTable dt1 = DBHelper.GetDataTable(sql1);
                    int count1 = dt1.Rows.Count;
                    //从结果中找到该账号
                    if (count1>0)
                    {
                        MessageBox.Show("该账号已注册", "提示");
                    }
                    else
                    {
                        //新增信息
                        string sql2 = string.Format(@"Insert Customer (CustomerName,CustomerUser,CustomerPwd,Tel,Vip,Sex,Customer_ImgString,Balance)
                                       values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", CustomerName, CustomerUser, CustomerPwd, Tel,VIP, Sex, ImageString,Balance);
                        //调用DBHelper的ExecuteNonQuery
                        if (DBHelper.ExecuteNonQuery(sql2))
                        {
                            MessageBox.Show("新增成功，点击确定为该用户填写密保");
                        }
                        //获取该注册的账号ID
                        string CustomerU = txtCustomerUser.Text;
                        Common.User = txtCustomerUser.Text;
                        string sql3 = string.Format("select * from Customer where CustomerUser = '{0}'", CustomerU);
                        DataTable dt2 = DBHelper.GetDataTable(sql3);
                        Common.ID = dt2.Rows[0][0].ToString();
                        //刷新数据
                        SelectInfo();
                        //显示窗体
                        Frm_SecretGuard frm_SecretGuard = new Frm_SecretGuard();
                        frm_SecretGuard.Show();
                    }
                }
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取用户选择的数据行的每一列数据
            //获取用户姓名
            txtCustomerName.Text = dgv.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            //获取性别
            if (dgv.SelectedRows[0].Cells["Sex"].Value.ToString() == "男")
            {
                rdoMan.Checked = true;
            }
            else
            {
                rdoWoman.Checked = true;
            }
            //获取是否管理员
            if (dgv.SelectedRows[0].Cells["Admin"].Value.ToString() == "是")
            {
                rdoYesAdmin.Checked = true;
            }
            else
            {
                rdoNoAdmin.Checked = true;
            }
            //获取是否Vip
            if (dgv.SelectedRows[0].Cells["VIP"].Value.ToString() == "是")
            {
                rdoYesVIP.Checked = true;
            }
            else
            {
                rdoNoVIP.Checked = true;
            }
            //获取用户账号
            txtCustomerUser.Text = dgv.SelectedRows[0].Cells["CustomerUser"].Value.ToString();
            //获取用户密码
            txtCustomerPwd.Text = dgv.SelectedRows[0].Cells["CustomerPwd"].Value.ToString();
            //获取用户电话
            txtCustomerTel.Text = dgv.SelectedRows[0].Cells["CustomerTel"].Value.ToString();
            //获取头像链接
            string image = dgv.SelectedRows[0].Cells["ImageString"].Value.ToString();
            img = image;
            FileStream fs = new FileStream(image, FileMode.Open);
            picturebytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            picturebytes = br.ReadBytes(Convert.ToInt32(fs.Length));
            MemoryStream ms = new MemoryStream(picturebytes);
            Bitmap bmpt = new Bitmap(ms);
            pbImage.Image = bmpt;
            fs.Close();
            //获取余额
            txtBalance.Text = dgv.SelectedRows[0].Cells["CustomerBalance"].Value.ToString();
            //获取ID
            lblID.Text = dgv.SelectedRows[0].Cells["CustomerID"].Value.ToString();    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //获取所有的填入的内容
            string CustomerID = lblID.Text;
            string CustomerName = txtCustomerName.Text;
            string CustomerUser = txtCustomerUser.Text;
            string CustomerPwd = txtCustomerPwd.Text;
            string Tel = txtCustomerTel.Text;
            string ImageString =img;
            string Balance = txtBalance.Text;
            string Sex = "";
            if (rdoMan.Checked) Sex = rdoMan.Text;
            else Sex = rdoWoman.Text;
            string Admin = "";
            if (rdoYesAdmin.Checked) Admin = rdoYesAdmin.Text;
            else Admin = rdoNoAdmin.Text;
            string VIP = "";
            if (rdoYesVIP.Checked) VIP = rdoYesVIP.Text;
            else VIP = rdoNoVIP.Text;
            //判断非空
            if (CustomerName.Equals("") || CustomerUser.Equals("") || CustomerPwd.Equals("") || Tel.Equals("") || ImageString.Equals("") || Balance.Equals(""))
            {
                MessageBox.Show("请将信息填写完整！", "提示");
                return;
            }
            //构造SQL语句
            string sql4 = string.Format(@"Update Customer Set CustomerName='{0}',
            CustomerUser='{1}',CustomerPwd='{2}',Tel='{3}',Vip='{4}',Sex='{5}',Balance='{6}',Admin='{7}',Customer_ImgString='{8}'  Where CustomerID={9}"
            , CustomerName,CustomerUser,CustomerPwd,Tel,VIP,Sex,Balance,Admin,ImageString,CustomerID);
            //调用DBHelper的ExecuteNonQuery
            if (DBHelper.ExecuteNonQuery(sql4))
            {
                MessageBox.Show("修改成功！");
                //刷新DataGridView
                SelectInfo();
            }
        }

        private void Frm_UserManage_Load(object sender, EventArgs e)
        {
            //刷新dgv
            SelectInfo();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹出消息框，提示用户是否删除
            DialogResult result = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo);
            //判断result是否为“是”
            if (result == DialogResult.Yes)
            {
                //删除操作
                //第一步:获取用户选择的这一行的学生id
                int CustomerID = int.Parse(dgv.SelectedRows[0].Cells["CustomerID"].Value.ToString());
                //第二步：创建删除SQL语句
                string sql5 = string.Format("delete from Customer where CustomerID={0}", CustomerID);
                string sql6 = string.Format("delete from Encrypted where CustomerID={0}", CustomerID);
                //第三步：调用DBHeiper类GetDataTable方法
                if (DBHelper.ExecuteNonQuery(sql6))
                {
                    MessageBox.Show("该用户密保删除成功！");
                }
                if (DBHelper.ExecuteNonQuery(sql5))
                {
                    MessageBox.Show("信息删除成功！");
                }
                //刷新数据
                SelectInfo();
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //拼接原始字符串
            string sql7 = "Select * from Customer ";
            //判断姓名或VIP,性别，管理不为空，拼接"where"关键字
            if (txtName.Text != "" || cmbAdmin.Text != "" || cmbVip.Text != "")
            {
                sql7 = sql7 + "Where ";
            }
            if (txtName.Text != "" && cmbAdmin.Text == "" && cmbVip.Text == "")
            {
                sql7 = sql7 + "CustomerName like '%" + txtName.Text + "%'";
            }
            else if (txtName.Text == "" && cmbAdmin.Text != "" && cmbVip.Text == "")
            {
                sql7 = sql7 + "Admin='" + cmbAdmin.Text + "'";
            }
            else if (txtName.Text == "" && cmbAdmin.Text == "" && cmbVip.Text != "")
            {
                sql7 = sql7 + "Vip='" + cmbVip.Text + "'";
            }
            else if (txtName.Text != "" && cmbAdmin.Text != "" && cmbVip.Text == "")
            {
                sql7 = sql7 + "CustomerName like '%" + txtName.Text + "%' and Admin='"+ cmbAdmin.Text+"'";
            }
            else if (txtName.Text != "" && cmbAdmin.Text == "" && cmbVip.Text != "")
            {
                sql7 = sql7 + "CustomerName like '%" + txtName.Text + "%' and Vip='" + cmbVip.Text + "'";
            }
            else if (txtName.Text == "" && cmbAdmin.Text != "" && cmbVip.Text != "")
            {
                sql7 = sql7 + "Admin='" + cmbAdmin.Text + "' and Vip='" + cmbVip.Text + "'";
            }
            else if (txtName.Text != "" && cmbAdmin.Text != "" && cmbVip.Text != "")
            {
                sql7 = sql7 + "CustomerName like'%" + txtName.Text + "%' and Admin='" + cmbAdmin.Text + "' and Vip='"+cmbVip.Text+"'";
            }
            //MessageBox.Show(sql);
            //调用DBHelper的GetDataTable
            DataTable dt3 = DBHelper.GetDataTable(sql7);
            //设置DataGridView的数据源为dt
            dgv.DataSource = dt3;
        }
        //头像图片链接
        string img = "";
        //选择头像图片
        byte[] picturebytes;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDlg = new OpenFileDialog();
            ofDlg.Filter = "*.jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                string fullpath = ofDlg.FileName;
                FileStream fs = new FileStream(fullpath, FileMode.Open);
                picturebytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                picturebytes = br.ReadBytes(Convert.ToInt32(fs.Length));
                MemoryStream ms = new MemoryStream(picturebytes);
                Bitmap bmpt = new Bitmap(ms);
                pbImage.Image = bmpt;
                //将选择的头像图片的链接传到img中
                img = ofDlg.FileName;
                fs.Close();
            }
            else
            {
                MessageBox.Show("图片打开失败");
            }
        }
        //设置刷新按钮
        private void btnShuaXin_Click(object sender, EventArgs e)
        {
            SelectInfo();
        }
    }
}
