using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_e_todo_projeto_cris
{
    class DbAcess
    {
        protected OleDbConnection _conn = null;
        public DbAcess(String connectionString)
        {
            try
            {
                _conn = new OleDbConnection(connectionString);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }

        }
        protected void Disconnect()
        {
            _conn.Close();
        }
        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    Disconnect();
                }
            }

            return DataSet;

        }

    }

}

