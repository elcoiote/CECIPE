using System;
using System.Collections.Generic;

namespace CCPv1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lstPessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Eduardo Silva de Azeredo Lopes";
            p1.Representante = "-";
            p1.DataInicioAssitenciaLar = "01/01/2018";
            p1.DataFimAssitenciaLar = "01/04/2018";
            p1.HoraAssitenciaLar = "02:20";
            p1.NumeroSemanas = 12;

            lstPessoas.Add(p1);
            ShowLstPessoas(lstPessoas);
            Console.ReadKey();
            Console.Clear();

            p1 = new Pessoa();
            p1.Nome = "Karla Berninger de Azeredo Lopes";
            p1.Representante = "-";
            p1.DataInicioAssitenciaLar = "02/02/2019";
            p1.DataFimAssitenciaLar = "02/02/2019";
            p1.HoraAssitenciaLar = "03:30";
            p1.NumeroSemanas = 10;

            lstPessoas.Add(p1);
            ShowLstPessoas(lstPessoas);
            Console.ReadKey();
            Console.Clear();

            Console.Clear();
            ShowMenu();

            Console.WriteLine("Fim do programa. Tecle algo para terminar.");
            Console.ReadKey();
        }

        static void ShowLstPessoas(List<Pessoa> lst)
        {
            foreach(Pessoa p in lst)
            {
                p.PrintMe();
                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            int opcao = Convert.ToInt32('0');

            do
            {
                Console.Clear();

                Console.WriteLine("[1] Incluir");
                Console.WriteLine("[2] Alterar");
                Console.WriteLine("[3] Excluir");
                Console.WriteLine("[4] Sair");

                opcao = Console.Read();

                switch(Convert.ToChar(opcao))
                {
                    case '1':
                        // Chamar rotina de inclusão
                        break;
                    case '2':
                        // Chamar rotina de inclusão
                        break;
                    case '3':
                        // Chamar rotina de inclusão
                        break;
                    case '4':
                        // Sair
                        break;
                }
            } while (Convert.ToChar(opcao) != '4');

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
