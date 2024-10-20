// Arquivo referente à classe SituacaoFinanceira

// O.B.S: Tomei a liberdade de criar um método extra que informa ao usuário se o seu saldo está positivo ou negativo

namespace questao9.models
{
    public class SituacaoFinanceira
    {
        public decimal ValorCreditos;
        public decimal ValorDebitos;

        public decimal CalcularSaldo()
        {
            return ValorCreditos - ValorDebitos;
        }

        public string RetornarEstadoDeSaldo()
        {
            if (ValorCreditos >= ValorDebitos)
            {
                return "SALDO POSITIVO";
            }
            else
            {
                return "SALDO NEGATIVO";
            }
        }
    }
}
