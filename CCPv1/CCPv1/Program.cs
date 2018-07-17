using CCP_Pessoa;
using System;
using System.Collections.Generic;

namespace CCPv1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Pessoa> lstPessoas = new List<Pessoa>();
            Pessoa p1 = new Pessoa
            {
                Nome = "Eduardo Silva de Azeredo Lopes",
                Representante = "-",
                DataInicioAssitenciaLar = "01/01/2018",
                DataFimAssitenciaLar = "01/04/2018",
                HoraAssitenciaLar = "02:20",
                NumeroSemanas = 12
            };

            lstPessoas.Add(p1);
            ShowLstPessoas(lstPessoas);
            Console.ReadKey();
            Console.Clear();

            p1 = new Pessoa
            {
                Nome = "Karla Berninger de Azeredo Lopes",
                Representante = "-",
                DataInicioAssitenciaLar = "02/02/2019",
                DataFimAssitenciaLar = "02/02/2019",
                HoraAssitenciaLar = "03:30",
                NumeroSemanas = 10
            };

            lstPessoas.Add(p1);
            ShowLstPessoas(lstPessoas);
            Console.ReadKey();
            Console.Clear();

            Console.Clear();
            ShowMenu(lstPessoas);

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

        static void ShowMenu(List<Pessoa> lst)
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

    

  
}
