using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using Dapper;

namespace ProductsCore
{
    public class Business
    {
        public List<Post> Query()
        {
            using (IDbConnection connect = new SqlConnection(SqlHelper.Sqlcon))
            {
                try
                {
                    Stopwatch st = new Stopwatch();
                    st.Start();
                    List<Post> list = connect.Query<Post>("SELECT * FROM Post").ToList();
                    st.Stop();
                    Console.WriteLine(st.ElapsedMilliseconds);
                    return list;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public List<Post> Query(Post strwhere)
        {
            using (IDbConnection connect = new SqlConnection(SqlHelper.Sqlcon))
            {
                try
                {
                    Stopwatch st = new Stopwatch();
                    st.Start();
                    List<Post> list = connect.Query<Post>("SELECT * FROM Post where id <= @id", strwhere).ToList();
                    st.Stop();
                    Console.WriteLine(st.ElapsedMilliseconds);
                    return list;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
