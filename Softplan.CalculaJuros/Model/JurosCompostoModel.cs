using System;


namespace Softplan.CalculaJuros.Model
{
    public class JurosCompostoModel
    {
        public JurosCompostoModel(double valorInicial, double juros, int tempo)
        {
            ValorFinal = Math.Round(valorInicial * Math.Pow((1 + juros), (double)tempo), 2);
        }
        public double ValorFinal { get; set; }
    }
}
