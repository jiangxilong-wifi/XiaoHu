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
    public partial class Frm_MovieType : Form
    {
        public Frm_MovieType()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //获取用户输入
            string MovieTypeName = txtType.Text;
            string sql1 = String.Format(@"insert MovieType (MovieTypeName)values('{0}')",MovieTypeName);
            string sql2 = "select * from MovieType where MovieTypeName='" + MovieTypeName + "'";
            //判断是否有该类型
            if (DBHelper.ExecuteNonQuery(sql2))
            {
                MessageBox.Show("已有该类型！");
            }
            else
            {
                if (DBHelper.ExecuteNonQuery(sql1))
                {
                    MessageBox.Show("添加类型成功！");
                    SelectInfo();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击数据使该数据信息显示在文本框上
            txtType.Text = dataGridView1.SelectedRows[0].Cells["MovieTypeName"].Value.ToString();
        }
        //创建更新方法
        private void SelectInfo()
        {
            string sql3 = "select * from MovieType";
            DataTable dt3 = DBHelper.GetDataTable(sql3);
            dataGridView1.DataSource = dt3;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //获取ID
            int ID = int.Parse(dataGridView1.SelectedRows[0].Cells["MovieTypeID"].Value.ToString());
            //定义修改语句
            string sql4 = string.Format(@"Update MovieType Set MovieTypeName='{0}' where MovieTypeID={1}", txtType.Text, ID);
            //修改
            if (DBHelper.ExecuteNonQuery(sql4))
            {
                MessageBox.Show("修改成功");
                //刷新数据源
                SelectInfo();
            }
        }

        private void Frm_MovieType_Load(object sender, EventArgs e)
        {
            //刷新数据
            SelectInfo();
        }
    }
}
