namespace Topico_13.Classes
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quant { get; set; }

        public Produto(string nome, double preco, int quant)
        {
            this.nome = nome;
            this.preco = preco;
            this.quant = quant;
        }

        public double Total()
        {
            return preco * quant;
        }
    }
}
