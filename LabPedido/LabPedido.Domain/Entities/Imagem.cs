using System.Collections.Generic;

namespace LabPedido.Domain
{
    public class Imagem : BaseDomain
    {
        public string Nome { get; set; }
        public string NomeArquivo { get; set; }
        public bool Principal { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
