using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_e_todo_projeto_cris
{
    public partial class Form2 : Form

    {
        private string todoText;
        private bool todoChecked;

        public Form2()
        {
            InitializeComponent();
           this.todoText = string.Empty;
            this.todoChecked = false;
        }

        public string currTodoText
        {
            get
            {
                return this.todoText;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.todoText = value;
                }
            }
        }
        public bool currTodoCheck
        {
            get
            {
                return this.todoChecked;
            }
            set
            {
                this.todoChecked = value;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
