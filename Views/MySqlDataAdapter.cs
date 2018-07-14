using System;
using System.Data;
using System.Data.SqlClient;

namespace ShirtBiz.Views
{
    internal class MySqlDataAdapter
    {
        private SqlConnection connection;
        private string selectQuery;

        public MySqlDataAdapter(string selectQuery, SqlConnection connection)
        {
            this.selectQuery = selectQuery;
            this.connection = connection;
        }

        internal void Fill(DataTable table)
        {
            throw new NotImplementedException();
        }
    }
}