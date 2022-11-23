namespace Progressao
{
    public abstract class Progressao
    {
        private int primeiro;
        private int razao;
        private int proximoValor;

        public int Razao { get { return razao; } }

        public Progressao(int primeiro, int razao)
        {
            this.primeiro = primeiro;
            this.razao = razao;
            proximoValor = this.primeiro;
        }

        public void Reinicializar()
        {
            proximoValor = primeiro;
        }

        public int TermoAt(int posicao)
        {
            return proximoValor;
        }
    }
}
