using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XiaoHuHouTai;

namespace XiaoHu
{
    public partial class Frm_MovieManage : Form
    {
        public Frm_MovieManage()
        {
            InitializeComponent();
            //为电影类型下拉框设置数据源
            string sql = string.Format("Select MovieTypeName from MovieType order by MovieTypeID");
            cmbMovieType.DataSource = DBHelper.GetDataSet(sql).Tables[0];
            cmbMovieType.DisplayMember = "MovieTypeName";
            cmbMovieType.ValueMember = "MovieTypeName";
        }
        //创建刷新方法
        private void SelectInfo()
        {
            //查询语句
            string sql = "select * from Movie m left join MovieType t on m.MovieTypeID=t.MovieTypeID";
            //调用DBHelper的GetDataTable
            DataTable dt = DBHelper.GetDataTable(sql);
            //设置DataGridView的数据源为dt
            dgv.DataSource = dt;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //获取所有的填入的内容
            string MovieName = txtMovieName.Text.ToString();
            string MovieType = cmbMovieType.Text.ToString();
            string MovieTime = txtMovieTime.Text.ToString();
            string MovieRatings = txtMoveiRatings.Text.ToString();
            string playString = txtPlayString.Text;
            string Cover = CoverStr; 
            string Tick = "";
            if (rdoYesTick.Checked) Tick = "是";
            else Tick = Tick = "否"; 
            string Play = "";
            if (rdoYesPlay.Checked) Play = "是";
            else Play = "否";
            string MovieDate = dtpMovieDate.Text.ToString();
            DateTime Date = Convert.ToDateTime(MovieDate);
            string Introduced = txtIntroduced.Text;
            //非空判断 
            if (MovieName == "" || MovieType == "" || MovieTime == "" || MovieRatings == "" || playString == "" || Cover == "" || MovieDate == "" || Introduced == "")
            {
                MessageBox.Show("请输入必填信息！");
                return;
            }
            else
            {
                //判断是否已有该电影
                String sql1 = String.Format("select * from Movie where MovieName='{0}'",MovieName);
                DataTable dt1 = DBHelper.GetDataTable(sql1);
                int count1 = dt1.Rows.Count;
                if (count1>0)
                {
                    MessageBox.Show("已有该电影！");
                    return;
                }
                else
                {   //对选择的电影创建文件夹
                    string MovieWJJ = @"F:\XiaoHu\XiaoHu\bin\Debug\Movie\" + MovieType + @"\" + MovieName;
                    //创建文件夹
                    Directory.CreateDirectory(MovieWJJ);
                    //拼接复制移动后的封面文件名
                    string newCover = MovieWJJ + @"\" + MovieName + ".jpg";
                    //复制移动封面文件
                    File.Copy(CoverStr, newCover);
                    //将封面文件的链接赋值到新增的数据里
                    Cover = newCover;
                    //移动视频文件
                    string newMoviePlay= MovieWJJ + @"\" + MovieName + ".MP4";
                    File.Copy(oldMoviePlay, newMoviePlay);
                    //将视频文件的链接赋值到新增的数据里
                    playString = newMoviePlay;
                    //获取类型ID
                    string sql2 = "select * from MovieType where MovieTypeName='" + MovieType + "'";
                    DataTable dt2 = DBHelper.GetDataTable(sql2);
                    int MovieTypeID = int.Parse(dt2.Rows[0][0].ToString());
                    //新增信息
                    string sql3 = string.Format(@"Insert Movie (MovieName,MovieTime,MovieTypeID,Movie_Ratings,Movie_PlayString,Movie_Cover,Movie_Tick,Movie_Play,Movie_Introduced,Date)
                                       values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}')", MovieName, MovieTime, MovieTypeID, MovieRatings, playString, Cover, Tick, Play, Introduced, Date);
                    if (DBHelper.ExecuteNonQuery(sql3))
                    {
                        MessageBox.Show("添加电影成功！");
                        SelectInfo();
                        return;
                    }
                }

            }

        }
        //窗体加载时进行刷新dgv
        private void Frm_MovieManage_Load(object sender, EventArgs e)
        {
            SelectInfo();
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取用户选择的数据行的每一列数据
            //获取电影名
            txtMovieName.Text = dgv.SelectedRows[0].Cells["MovieName"].Value.ToString();
            //获取是否可购票
            if (dgv.SelectedRows[0].Cells["MovieTick"].Value.ToString() == "是")
            {
                rdoYesTick.Checked = true;
            }
            else
            {
                rdoNoTick.Checked = true;
            }
            //获取是否可观看
            if (dgv.SelectedRows[0].Cells["MoviePlay"].Value.ToString() == "是")
            {
                rdoYesPlay.Checked = true;
            }
            else
            {
                rdoNoPlay.Checked = true;
            }
            
            //获取电影类型
            cmbMovieType.Text = dgv.SelectedRows[0].Cells["MovieType"].Value.ToString();
            //获取电影时长
            txtMovieTime.Text = dgv.SelectedRows[0].Cells["MovieTime"].Value.ToString();
            //获取电影评分
            txtMoveiRatings.Text = dgv.SelectedRows[0].Cells["MovieRatings"].Value.ToString();
            //获取电影连接
            txtPlayString.Text = dgv.SelectedRows[0].Cells["PlayString"].Value.ToString();
            //获取封面
            string CoverString = dgv.SelectedRows[0].Cells["MovieCover"].Value.ToString();
            CoverStr = CoverString;
            FileStream fs = new FileStream(CoverString, FileMode.Open);
            picturebytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            picturebytes = br.ReadBytes(Convert.ToInt32(fs.Length));
            MemoryStream ms = new MemoryStream(picturebytes);
            Bitmap bmpt = new Bitmap(ms);
            pbCover.Image = bmpt;
            fs.Close();
            //获取ID
            lblID.Text = dgv.SelectedRows[0].Cells["MovieID"].Value.ToString();
            //获取介绍
            txtIntroduced.Text = dgv.SelectedRows[0].Cells["MovieIntroduced"].Value.ToString();
            //获取上映时间
            dtpMovieDate.Text= dgv.SelectedRows[0].Cells["MovieDate"].Value.ToString();
            //获取电影ID
            lblID.Text = dgv.SelectedRows[0].Cells["MovieID"].Value.ToString();
        }
        //string playStr = "";
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //获取所有的填入的内容
        //    int ID = int.Parse(lblID.Text.ToString());
        //    string MovieName = txtMovieName.Text.ToString();
        //    string MovieType = cmbMovieType.Text.ToString();
        //    string MovieTime = txtMovieTime.Text.ToString();
        //    string MovieRatings = txtMoveiRatings.Text.ToString();
        //    //获取数据库中的视频链接
        //    string ps = dgv.SelectedRows[0].Cells["PlayString"].Value.ToString();

        //    //判断视频链接是否变化
        //    if (ps==playStr)
        //    {
        //        playStr = ps;
        //    }
        //    else
        //    {
        //        playStr = oldMoviePlay;
        //    }
        //    //获取数据库的封面链接
        //    string cs = dgv.SelectedRows[0].Cells["MovieCover"].Value.ToString();
        //    string Cover = CoverStr;
        //    //判断封面链接是否发生变化
        //    if (cs==Cover)
        //    {
        //        Cover = CoverStr;
        //    }
        //    else
        //    {
        //        //判断是否存在该文件
        //        if (File.Exists(cs))
        //        {
        //            //删除该文件
        //            File.Delete(cs);
        //        }
        //        //对选择的电影创建文件夹
        //        string MovieWJJ = @"C: \Users\12939\Desktop\XiaoHu\XiaoHu\bin\Debug\Movie\" + MovieType + @"\" + MovieName;
        //        //拼接复制移动后的封面文件名
        //        string newCover = MovieWJJ + @"\" + MovieName + ".jpg";
        //        //复制移动封面文件
        //        File.Copy(CoverStr, newCover);
        //        //将封面文件的链接赋值到新增的数据里
        //        Cover = newCover;
        //    }
        //    string Tick = "";
        //    if (rdoYesTick.Checked) Tick = "是";
        //    else Tick = Tick = "否";
        //    string Play = "";
        //    if (rdoYesPlay.Checked) Play = "是";
        //    else Play = "否";
        //    string MovieDate = dtpMovieDate.Text.ToString();
        //    DateTime Date = Convert.ToDateTime(MovieDate);
        //    string Introduced = txtIntroduced.Text;

        //    //非空判断 
        //    if (MovieName == "" || MovieType == "" || MovieTime == "" || MovieRatings == "" || playStr == "" || Cover == "" || MovieDate == "" || Introduced == "")
        //    {
        //        MessageBox.Show("请输入必填信息！");
        //        return;
        //    }
        //    else
        //    {
        //        string sql4 = "select * from MovieType where MovieTypeName='" + MovieType + "'";
        //        DataTable dt4 = DBHelper.GetDataTable(sql4);
        //        int MovieTypeID = int.Parse(dt4.Rows[0][0].ToString());
        //        //修改信息
        //        string sql5 = string.Format(@"Update Movie Set MovieName='{0}',MovieTime='{1}',MovieTypeID={2},Movie_Ratings='{3}',Movie_PlayString='{4}',Movie_Cover='{5}',Movie_Tick='{6}',Movie_Play='{7}',Movie_Introduced='{8}',Date='{9}' where MovieID={10}"
        //                                    , MovieName, MovieTime, MovieTypeID, MovieRatings, playStr, Cover, Tick, Play, Introduced, Date,ID);
        //        //MessageBox.Show(sql5);
        //        if (DBHelper.ExecuteNonQuery(sql5))
        //        {
        //             MessageBox.Show("修改电影成功！");
        //             SelectInfo();
        //             return;
        //        }
        //    }
        //}

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹出消息框，提示用户是否删除
            DialogResult result = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo);
            //判断result是否为“是”
            if (result == DialogResult.Yes)
            {
                //删除操作
                //第一步:获取用户选择的这一行的电影id
                int MovieID = int.Parse(dgv.SelectedRows[0].Cells["MovieID"].Value.ToString());
                //获取电影类型
                string Type = dgv.SelectedRows[0].Cells["MovieType"].Value.ToString();
                //获取电影名
                string Name = dgv.SelectedRows[0].Cells["MovieName"].Value.ToString();
                //对选择的电影新建文件夹路径
                string Path = @"F:\XiaoHu\XiaoHu\bin\Debug\Movie\" + Type + @"\" + Name;
                //第二步：创建删除SQL语句
                string sql6 = string.Format("delete from Movie where MovieID={0}", MovieID);
                //第三步：调用DBHeiper类GetDataTable方法
                if (DBHelper.ExecuteNonQuery(sql6))
                {
                    //判断是否存在该文件夹
                    if (Directory.Exists(Path))
                    {
                        //删除文件夹以及其子文件
                        Directory.Delete(Path, true);
                        MessageBox.Show("信息删除成功！");
                    }
                }
                //清除显示的数据
                txtMovieName.Text = "";
                cmbMovieType.Text = "美国大片";
                txtMovieTime.Text = "";
                txtMoveiRatings.Text = "";
                txtPlayString.Text = "";
                rdoYesTick.Checked = true;
                rdoYesPlay.Checked = true;
                txtIntroduced.Text = "";
                pbCover.Image =null;
                dtpMovieDate.Value = DateTime.Now;
                //刷新dgv数据
                SelectInfo();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //拼接原始字符串
            string sql7 = "Select * from Movie ";
            //判断电影名和评分不为空，拼接"where"关键字
            if (txtName.Text != "" || txtRatings.Text != "")
            {
                sql7 = sql7 + "Where ";
            }
            if (txtName.Text != ""  && txtRatings.Text == "")
            {
                sql7 = sql7 + "MovieName like '%" + txtName.Text + "%'";
            }
            else if (txtName.Text == "" && txtRatings.Text != "")
            {
                sql7 = sql7 + "Movie_Ratings ='" + txtRatings.Text + "'";
            }
            else if (txtName.Text != "" && txtRatings.Text != "")
            {
                sql7 = sql7 + "MovieName like '%" + txtName.Text + "%'"+ " and Movie_Ratings ='"+ txtRatings.Text + "'";
            }
            //MessageBox.Show(sql);
            //调用DBHelper的GetDataTable
            DataTable dt7 = DBHelper.GetDataTable(sql7);
            //设置DataGridView的数据源为dt
            dgv.DataSource = dt7;
        }
        //头像图片链接
        string CoverStr = "";
        //选择头像图片
        byte[] picturebytes;
        
        private void btnCover_Click(object sender, EventArgs e)
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
                pbCover.Image = bmpt;
                //将选择的头像图片的链接传到img中
                CoverStr = ofDlg.FileName;
                fs.Close();
            }
            else
            {
                MessageBox.Show("图片打开失败");
            }
        }
        string oldMoviePlay = "";
        //打开选择的视频链接
        private void btnMovie_Click(object sender, EventArgs e)
        {
            //设置电影格式
            ofDlg.Filter = ".avi|*.AVI|.wmv|*.WMV|.mp4|*.MP4";
            ofDlg.FilterIndex = 1;
            ofDlg.Title = "选择要打开的视频文件";
            if (ofDlg.ShowDialog()==DialogResult.OK)
            {
                //将选择的电影路径传入该文本框
                txtPlayString.Text = ofDlg.FileName;
                oldMoviePlay = ofDlg.FileName;
            }
        }
    }
}
