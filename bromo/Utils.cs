using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace bromo
{
    internal class Utils
    {
        private readonly string conn =@"Data Source=TUNBUDI06\SQLEXPRESS;Initial Catalog=BromoAirlines;Integrated Security=True;Encrypt=False";


        public SqlConnection koneksi()
        {
            return new SqlConnection(conn); ;
        }

        //public SqlDataReader sqlreader(string query, SqlParameter[] parameters)
        //{
        //    SqlDataReader reader = null;
        //    SqlConnection conn = koneksi();

        //    using (SqlCommand cmd = conn.CreateCommand())
        //    {
        //        conn.Open();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = query;
        //        if (parameters != null)
        //        {
        //            cmd.Parameters.AddRange(parameters);
        //        }

        //        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        //        return reader;
        //    }
        //}

        //public SqlDataAdapter sqlselect(string query, SqlParameter[] parameters)
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    SqlConnection conn = koneksi();


        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = query;

        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters);
        //    }

        //    adapter.SelectCommand = cmd;

        //    conn.Open();
        //    return adapter;
        //}

        //public SqlDataAdapter sqlupdate(string query, SqlParameter[] parameters)
        //{
        //    SqlConnection conn = koneksi();
        //    SqlDataAdapter adapter = new SqlDataAdapter();

        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = query;

        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters);
        //    }

        //    adapter.UpdateCommand = cmd;

        //    conn.Open();
        //    return adapter;
        //}

        //public SqlCommand sqlinsert(string query, SqlParameter[] parameters)
        //{
        //    SqlConnection conn = koneksi();
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = query;

        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters);
        //    }

        //    conn.Open();
        //    return cmd;
        //}

        //public SqlDataAdapter sqldelete(string query, SqlParameter[] parameters)
        //{
        //    SqlConnection conn = koneksi();
        //    SqlDataAdapter adapter = new SqlDataAdapter();

        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = query;

        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters);
        //    }

        //    adapter.DeleteCommand = cmd;

        //    conn.Open();
        //    return adapter;
        //}
    }
}
