using System.Runtime.CompilerServices;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        //Lista de Produtos 
        List<Produtos> itens = new List<Produtos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var item = new Produtos
            {
                Nome = txtNome.Text,
                Categoria = txtCategoria.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text),
            };

            itens.Add(item);
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = itens;

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itens.Clear();

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = itens; itens.Clear();

        }
    }
}
public class Produtos
{
    public string Nome { get; set; } = "";
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string Categoria { get; set; } = "";
}
