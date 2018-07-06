using System;

namespace CCPv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Eduardo Silva de Azeredo Lopes";
            p1.Representante = "-";
            p1.DataInicioAssitenciaLar = "01/01/2018";
            p1.DataFimAssitenciaLar = "01/04/2018";
            p1.HoraAssitenciaLar = "02:20";
            p1.NumeroSemanas = 12;

            p1.PrintMe();

            Console.ReadKey();

        }
    }

    class Pessoa
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
