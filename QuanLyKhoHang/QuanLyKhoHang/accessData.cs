﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    class accessData
    {
        public SqlConnection getconnection()
        {
<<<<<<< HEAD
            return new SqlConnection(@"Data Source=DESKTOP-H1LP27V;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
=======
            return new SqlConnection(@"Data Source=DESKTOP-6KM2KGB\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");

            //return new SqlConnection(@"Data Source=NGOCDATNGUYEN\SQLEXPRESS;Initial Catalog=QuanLyKhoHang;Integrated Security=True");
>>>>>>> 082e31818e23695496724efd183daf1d141d8b55
        }
        public bool excuteNonQuery(String sql)
        {
            SqlConnection connection = (SqlConnection)getconnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            return true;
        }
        public SqlDataReader ExecuteReader(String sql)
        {
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int executeScalar(string sql)
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int n = (int)cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            return n;

        }
        public SqlDataAdapter executeDatatable(string sql)
        {
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            return sda;
        }

    }
}
