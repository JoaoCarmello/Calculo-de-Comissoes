using calculoComissao.Models;
using calculoComissao.Controllers;

namespace calculoComissao
{
    public partial class frmCalcularComissao : Form
    {
        private readonly VendaController _vendaController;
        public frmCalcularComissao()
        {
            InitializeComponent();

            _vendaController = new VendaController();

            ConfigurarDataGridView();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularComissoes();
        }

        private void ConfigurarDataGridView()
        {
            dgvComissoes.Columns.Clear();

            dgvComissoes.Columns.Add("Vendedor", "Vendedor");

            dgvComissoes.Columns.Add("Comissao", "Comissão");

            dgvComissoes.Columns["Comissao"].DefaultCellStyle.Format = "C2";
        }

        public void CalcularComissoes()
        {
            try
            {
                string caminhoArquivo = Path.Combine(Application.StartupPath, "Data", "Vendas.json");

                List<Venda> vendas = _vendaController.LerVendasDoArquivo(caminhoArquivo);

                if (vendas.Count == 0)
                {
                    MessageBox.Show("Nenhuma venda foi encontrada no arquivo JSON.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, decimal> comissoes = _vendaController.CalcularComissaoVendedores(vendas);

                LimparCampos();

                MessageBox.Show($"Cálculo concluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var comissao in comissoes)
                {
                    dgvComissoes.Rows.Add(comissao.Key, comissao.Value);
                }

                lblValorTotal.Text = $"{comissoes.Values.Sum():C2}";
                lblVendedores.Text = $"{comissoes.Keys.Count()}";
                lblVendas.Text = $"{vendas.Count}";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular as comissões:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            dgvComissoes.Rows.Clear();
            lblVendas.Text = "";
            lblVendedores.Text = "";
            lblValorTotal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCalcularComissao_Load(object sender, EventArgs e)
        {

        }
    }
}
