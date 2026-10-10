using calculoComissao.Models;
using System.Text.Json;

namespace calculoComissao.Controllers
{
    public class VendaController
    {
        private readonly Services.ComissaoService _comissaoService;
        public VendaController()
        {
            _comissaoService = new Services.ComissaoService();
        }
        public decimal CalcularComissao(decimal valorVenda)
        {
            return _comissaoService.CalcularComissao(valorVenda);
        }
        public Dictionary<string, decimal> CalcularComissaoVendedores(List<Venda> vendas)
        {
            var comissaoPorVendedor = new Dictionary<string, decimal>();
            
            foreach (var venda in vendas)
            {
                if (!comissaoPorVendedor.ContainsKey(venda.Vendedor))
                {
                    comissaoPorVendedor[venda.Vendedor] = 0;
                }
                comissaoPorVendedor[venda.Vendedor] += _comissaoService.CalcularComissao(venda.Valor);
            }
            return comissaoPorVendedor;
        }
       public List<Venda> LerVendasDoArquivo(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
            {
                throw new FileNotFoundException("O arquivo de vendas não foi encontrado.",caminhoArquivo);
            }

            string json = File.ReadAllText(caminhoArquivo);

            var opcoes = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var dadosVendas = JsonSerializer.Deserialize<DadosVendas>(json,opcoes);

            return dadosVendas?.Vendas ?? new List<Venda>();
        }
    }
}
