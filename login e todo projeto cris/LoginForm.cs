using login_e_todo_projeto_cris.Controle;
using login_e_todo_projeto_cris.Modelo;
using System;
using System.Windows.Forms;

namespace login_e_todo_projeto_cris
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_login login = new tb_login
                {
                    LOGIN_USU = txbUsuario.Text,
                    SENHA_USU = txbSenha.Text
                };

                tb_loginControle tb_LoginControle = new tb_loginControle();

                if (tb_LoginControle.Logar(login))
                {
                    Hide();

                    TodoForm frm = new TodoForm();

                    frm.Show();
                }
                else
                {
                    throw new ArgumentException("Usuário ou senha inválida!");
                }
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

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            CadastroForm frm = new CadastroForm();

            frm.ShowDialog();
        }
    }
}
