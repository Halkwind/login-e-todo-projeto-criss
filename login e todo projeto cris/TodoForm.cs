using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static login_e_todo_projeto_cris.TodoDataSet;

namespace login_e_todo_projeto_cris
{
    public partial class TodoForm : Form
    {
        private TodoRow Tupla;

        public TodoForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxDescricao.Text))
                    throw new ArgumentException("Informe a descrição");

                Tupla = todoDataSet.Todo.NewTodoRow();

                if (todoDataSet.Todo.Count == 0)
                    Tupla.IDTodo = 1;
                else
                    Tupla.IDTodo = todoDataSet.Todo.Max(x => x.IDTodo) + 1;

                Tupla.Descricao = textBoxDescricao.Text;
                Tupla.Concluida = false;
                Tupla.Selecionar = false;

                todoDataSet.Todo.AddTodoRow(Tupla);

                textBoxDescricao.Clear();
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == nameof(ColumnExcluir))
            {
                Tupla = (bindingSource.Current as DataRowView).Row as TodoRow;

                DialogResult dialog = MessageBox.Show($"Atenção\n\nDeseja excluir a tarefa: {Tupla.Descricao}?", "Questionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialog == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                }
            }

            PersonalizarGrid();
        }

        private void TodoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PersonalizarGrid()
        {
            dataGridView.EndEdit();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewRow dr = dataGridView.Rows[i];

                Tupla = (dr.DataBoundItem as DataRowView).Row as TodoRow;

                if (Tupla.Concluida)
                    dr.DefaultCellStyle.ForeColor = Color.Green;
                else
                    dr.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
