using MySql.Data.MySqlClient;
using System.Data;

namespace login_e_todo_projeto_cris.Conexao
{
    public class MySqlConexao
    {
        public MySqlConnection Conectar()
        {
            MySqlConnection conn = new MySqlConnection("User ID=root;Password=;Host=localhost;Port=3306;Database=cris;Protocol=TCP;Compress=false;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;");

            conn.Open();

            return conn;
        }

        public DataRow SelecionarRegistro(string sql)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conn = Conectar())
            {
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    tabela.Load(reader);
            }

            if (tabela.Rows.Count > 0)
                return tabela.Rows[0];

            return null;
        }

        public int ExecutarScript(string sql)
        {
            int linha = 0;

            using (MySqlConnection conn = Conectar())
            {
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                linha = cmd.ExecuteNonQuery();
            }

            return linha;
        }

        public DataTable Consulta(string sql)
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection conn = Conectar())
            {
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    tabela.Load(reader);
            }

            return tabela;
        }
    }
}
