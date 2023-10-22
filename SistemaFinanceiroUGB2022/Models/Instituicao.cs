using System.ComponentModel;

namespace SistemaFinanceiroUGB2022.Models
{
    public class Instituicao
    {
        [DisplayName("Código")]

        public long? InstitucaoId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
