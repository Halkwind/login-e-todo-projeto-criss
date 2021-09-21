
namespace login_e_todo_projeto_cris
{
    partial class TodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoForm));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoDataSet = new login_e_todo_projeto_cris.TodoDataSet();
            this.Concluida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insira aqui:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(25, 60);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(378, 20);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(409, 59);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Adicionar Todo";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concluida,
            this.descricaoDataGridViewTextBoxColumn,
            this.ColumnExcluir});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 102);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(480, 294);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Todo";
            this.bindingSource.DataSource = this.todoDataSet;
            // 
            // todoDataSet
            // 
            this.todoDataSet.DataSetName = "TodoDataSet";
            this.todoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Concluida
            // 
            this.Concluida.DataPropertyName = "Concluida";
            this.Concluida.HeaderText = "Done";
            this.Concluida.Name = "Concluida";
            this.Concluida.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // ColumnExcluir
            // 
            this.ColumnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColumnExcluir.HeaderText = "Ação";
            this.ColumnExcluir.Name = "ColumnExcluir";
            this.ColumnExcluir.Text = "Excluir";
            this.ColumnExcluir.UseColumnTextForButtonValue = true;
            // 
            // TodoForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 554);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TodoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private TodoDataSet todoDataSet;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Concluida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnExcluir;
    }
}