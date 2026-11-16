namespace Atividade_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btName = new Button();
            btCadastrar = new Button();
            tbCategoria = new Button();
            tbQuantidade = new Button();
            tbPreco = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbName = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, -4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1275, 848);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1267, 815);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(706, 121);
            tabControl2.Margin = new Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(229, 133);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(221, 100);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(221, 100);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btName);
            groupBox1.Controls.Add(btCadastrar);
            groupBox1.Controls.Add(tbCategoria);
            groupBox1.Controls.Add(tbQuantidade);
            groupBox1.Controls.Add(tbPreco);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 7);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(657, 547);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Produtos ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 333);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(659, 212);
            dataGridView1.TabIndex = 11;
            // 
            // btName
            // 
            btName.Location = new Point(176, 44);
            btName.Margin = new Padding(3, 4, 3, 4);
            btName.Name = "btName";
            btName.Size = new Size(304, 31);
            btName.TabIndex = 10;
            btName.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.Location = new Point(176, 295);
            btCadastrar.Margin = new Padding(3, 4, 3, 4);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(311, 31);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Cadastrar Produto";
            btCadastrar.UseVisualStyleBackColor = true;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(176, 161);
            tbCategoria.Margin = new Padding(3, 4, 3, 4);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(304, 31);
            tbCategoria.TabIndex = 8;
            tbCategoria.UseVisualStyleBackColor = true;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(176, 103);
            tbQuantidade.Margin = new Padding(3, 4, 3, 4);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(311, 31);
            tbQuantidade.TabIndex = 7;
            tbQuantidade.UseVisualStyleBackColor = true;
            tbQuantidade.Click += button3_Click;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(176, 212);
            tbPreco.Margin = new Padding(3, 4, 3, 4);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(192, 31);
            tbPreco.TabIndex = 6;
            tbPreco.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 161);
            label4.Name = "label4";
            label4.Size = new Size(160, 19);
            label4.TabIndex = 4;
            label4.Text = "Categoria do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 108);
            label3.Name = "label3";
            label3.Size = new Size(173, 19);
            label3.TabIndex = 3;
            label3.Text = "Quantidade em estoque:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 219);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 2;
            label2.Text = "Preço:";
            // 
            // tbName
            // 
            tbName.AutoSize = true;
            tbName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.Location = new Point(13, 49);
            tbName.Name = "tbName";
            tbName.Size = new Size(135, 19);
            tbName.TabIndex = 0;
            tbName.Text = "Nome do Produto:";
            tbName.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1267, 815);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 831);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private Label tbName;
        private Button btCadastrar;
        private Button tbCategoria;
        private Button tbQuantidade;
        private Button tbPreco;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btName;
        private DataGridView dataGridView1;
    }
}
