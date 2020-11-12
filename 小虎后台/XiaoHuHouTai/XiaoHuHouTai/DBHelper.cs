﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace XiaoHuHouTai
{
    class DBHelper
    {
        //数据库连接字符串
        public static string ConnString = "server=106.54.89.71;database=XiaohuDB;uid=sa;pwd=@sisi401856538";
        //数据库连接对象
        public static SqlConnection Conn = null;
        //初始化数据库连接
        public static void InitConnection()
        {
            //连接对象不存在，则创建连接
            if (Conn == null)
            {
                Conn = new SqlConnection(ConnString);
            }
            //连接对象关闭则打开连接
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            //连接中断则重启连接
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }
        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            //当DataReader对象被关闭时，自动关闭占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //进行查询的
        public static DataTable GetDataTable(string sql)
        {
            //初始化连接
            InitConnection();
            //创建DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
            //创建DataTable
            DataTable dt = new DataTable();

            //调用Fill方法，填充DataTable
            adapter.Fill(dt);
            //返回DataTable对象
            return dt;
        }
        //增删改操作
        public static bool ExecuteNonQuery(String sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }
        //执行聚合函数
        public static object ExecuteScalar(String sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
        public static DataSet GetDataSet(String sql)
        {
            InitConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
