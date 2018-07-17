using System;

namespace CCP_Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Representante { get; set; }
        public string DataInicioAssitenciaLar { get; set; }
        public string DataFimAssitenciaLar { get; set; }
        public string HoraAssitenciaLar { get; set; }
        public int NumeroSemanas { get; set; }

        public void PrintMe()
        {
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Representante: {0}", Representante);
            Console.WriteLine("Assistência no Lar - período de {0} a {1} às {2}",
                DataInicioAssitenciaLar, DataFimAssitenciaLar, HoraAssitenciaLar);
            Console.WriteLine("Reuniões Públicas - Palestras e Passes  - durante {0} semanas",
                NumeroSemanas);
        }
    }
}
