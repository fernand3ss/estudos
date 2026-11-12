namespace Atividade1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lbQuantidade = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            tbPreco = new TextBox();
            tbQuantidade = new TextBox();
            tbCategoria = new TextBox();
            dgLista = new DataGridView();
            btnCadastrar = new Button();
            button2 = new Button();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            label2.Click += label2_Click;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(39, 188);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(87, 20);
            lbQuantidade.TabIndex = 2;
            lbQuantidade.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 266);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 239);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 70);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 5;
            // 
            // tbPreco
            // 
            tbPreco.Location = new Point(12, 142);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(125, 27);
            tbPreco.TabIndex = 6;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(12, 220);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(125, 27);
            tbQuantidade.TabIndex = 7;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(12, 289);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(125, 27);
            tbCategoria.TabIndex = 8;
            tbCategoria.TextChanged += textBox4_TextChanged;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(335, 47);
            dgLista.Name = "dgLista";
            dgLista.RowHeadersWidth = 51;
            dgLista.Size = new Size(453, 344);
            dgLista.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(186, 117);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 201);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(513, 24);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 12;
            label6.Text = "Lista de Itens";
            label6.Click += label6_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btnCadastrar);
            Controls.Add(dgLista);
            Controls.Add(tbCategoria);
            Controls.Add(tbQuantidade);
            Controls.Add(tbPreco);
            Controls.Add(tbName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbQuantidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dgLista;
        private Button btnCadastrar;
        private Button button2;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbQuantidade;
        private Label lbQuantidade;
        private TextBox tbPreco;
        private TextBox tbCategoria;
    }
}
