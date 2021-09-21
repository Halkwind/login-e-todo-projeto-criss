using login_e_todo_projeto_cris.Conexao;
using login_e_todo_projeto_cris.Modelo;
using System;
using System.Data;

namespace login_e_todo_projeto_cris.Controle
{
    public class tb_loginControle
    {
        public bool Logar(tb_login login)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login.LOGIN_USU))
                    throw new ArgumentException("Informe o Usuario!");

                if (string.IsNullOrWhiteSpace(login.SENHA_USU))
                    throw new ArgumentException("Informe a senha!");

                MySqlConexao bd = new MySqlConexao();

                DataRow linha = bd.SelecionarRegistro($"SELECT * FROM tb_login WHERE LOGIN_USU = '{login.LOGIN_USU}' AND SENHA_USU = '{login.SENHA_USU}'");

                return linha != null;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Inserir(tb_login login)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login.LOGIN_USU))
                    throw new ArgumentException("Informe o Usuario!");

                if (string.IsNullOrWhiteSpace(login.SENHA_USU))
                    throw new ArgumentException("Informe a senha!");

                MySqlConexao bd = new MySqlConexao();

                string sql = $@"INSERT INTO tb_login(NOME_USU,LOGIN_USU,SENHA_USU) VALUES('{login.NOME_USU}', '{login.LOGIN_USU}','{login.SENHA_USU}');";

                int linha = bd.ExecutarScript(sql);

                if (linha == 0)
                    throw new Exception("Não foi possivel inserir o login no banco de dados");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
