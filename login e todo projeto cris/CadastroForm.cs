using login_e_todo_projeto_cris.Controle;
using login_e_todo_projeto_cris.Modelo;
using System;
using System.Windows.Forms;

namespace login_e_todo_projeto_cris
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_login login = new tb_login
                {
                    NOME_USU = txbUsuario.Text,
                    LOGIN_USU = txbUsuario.Text,
                    SENHA_USU = txbSenha.Text
                };

                tb_loginControle tb_LoginControle = new tb_loginControle();

                tb_LoginControle.Inserir(login);

                MessageBox.Show($"Usuario: {login.NOME_USU} inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
