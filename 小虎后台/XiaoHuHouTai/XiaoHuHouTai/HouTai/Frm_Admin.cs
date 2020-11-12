using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiaoHu
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }
        //点击进入用户管理界面
        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UserManage frm_UserManage = new Frm_UserManage();
            frm_UserManage.TopLevel = false;
            frm_UserManage.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm_UserManage);
            frm_UserManage.Show();
        }
        //点击退出程序
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //点击进入影片管理界面
        private void 影片管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovieManage frm_MovieManage = new Frm_MovieManage();
            frm_MovieManage.TopLevel = false;
            frm_MovieManage.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm_MovieManage);
            frm_MovieManage.Show();
        }
        //点击进入影片类型管理界面
        //private void 影片管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Frm_MovieType frm_MovieType = new Frm_MovieType();
        //    frm_MovieType.TopLevel = false;
        //    frm_MovieType.Dock = DockStyle.Fill;
        //    panel1.Controls.Clear();
        //    panel1.Controls.Add(frm_MovieType);
        //    frm_MovieType.Show();
        //}
    }
}
