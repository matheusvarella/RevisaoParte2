namespace Progressao
{
    public class ProgressaoGeometrica : Progressao
    {
        private int proximoValor;
        public int ProximoValor 
        { 
            get
            {
                var aux = proximoValor;

                proximoValor = proximoValor * Razao;

                return aux;
            } 
        }

        public ProgressaoGeometrica(int primeiro, int razao) : base(primeiro, razao)
        {
            proximoValor = primeiro;
        }
    }
}
