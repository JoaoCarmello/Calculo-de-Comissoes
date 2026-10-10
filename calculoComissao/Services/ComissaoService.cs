
namespace calculoComissao.Services
{
    public class ComissaoService
    {
        public decimal CalcularComissao(decimal valorVenda)
        {
            if (valorVenda < 100m)
                return 0m;

            if (valorVenda < 500m)
                return valorVenda * 0.01m;

            return valorVenda * 0.05m;
        }
    }
}
