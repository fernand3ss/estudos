namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        List<object> itens = new List<object>();

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new
            {
                Name = tbName.Text,
                Preco = tbPreco.Text,
                Quantidade = tbQuantidade.Text,
                Categoria = tbCategoria.Text
            };

            itens.Add(item);

            dgLista.DataSource = null;
            dgLista.DataSource = itens;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var item = new
            {
                Name = tbName.Text,
                Preco = tbPreco.Text,
                Quantidade = tbQuantidade.Text,
                Categoria = tbCategoria.Text
            };
            itens.Remove(item);
            
            dgLista.DataSource = null;
            dgLista.DataSource = itens;
        }
    }
}

