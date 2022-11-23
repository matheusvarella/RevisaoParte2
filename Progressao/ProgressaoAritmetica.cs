namespace Progressao
{
    internal class ProgressaoAritmetica : Progressao
    {
        private int proximoValor;
        public int ProximoValor
        {
            get
            {
                var aux = proximoValor;

                proximoValor = proximoValor + Razao;

                return aux;
            }
        }

        public ProgressaoAritmetica(int primeiro, int razao) : base(primeiro, razao)
        {
            proximoValor = primeiro;
        }
    }
}
