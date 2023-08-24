namespace Estoque
{

    class ControleEstoque
    {
        private string _nomeProduto;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public ControleEstoque()
        {

        }
        public ControleEstoque(string nomeProduto, double preco, int quantidade)
        {
            _nomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nomeProduto; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nomeProduto = value;
                }
            }
        }
        public double ValorToralemEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nomeProduto
                + ", R$"
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " Unidades, Total: R$"
                + ValorToralemEstoque().ToString("F2");
        }

    }
}