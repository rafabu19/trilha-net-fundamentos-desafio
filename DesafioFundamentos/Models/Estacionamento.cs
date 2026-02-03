using Microsoft.Win32.SafeHandles;
namespace DesafioFundamentos.Models;
    
   
    public class Estacionamento

    {

        private decimal precoInicial = 0;

        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();



        public Estacionamento(decimal precoInicial, decimal precoPorHora)

        {

            this.precoInicial = precoInicial;

            this.precoPorHora = precoPorHora;

        }



        public void AdicionarVeiculo()

        {

           //e adicionar na lista "veiculos"

            // *IMPLEMENTE AQUI*

            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();



            veiculos.Add(placa);

            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");

        }



        public void RemoverVeiculo()

        {

            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();


 // Verifica se o veículo existe

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))

            {
                 Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                

                // *IMPLEMENTE AQUI*

                decimal horas = 0;

                decimal valorTotal = 0;

        if(decimal.TryParse(Console.ReadLine(), out horas))

                {

                    valorTotal = precoInicial + (precoPorHora * horas);
                    Console.WriteLine($"O valor total a pagar é: {valorTotal:C}");

                  veiculos.Remove(veiculos.First( x=> x.ToUpper() == placa.ToUpper()));  
                  Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
        else
        {
          Console.WriteLine("Valor inválido! Por favor, digite um número (ex: 2 ou 1,5)");
        }

      }
      else
      {
           Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }

        }



        public void ListarVeiculos()

        {
            // Verifica se há veículos no estacionamento
             if (veiculos.Any())
             {
               Console.WriteLine("Os veículos estacionados são:");
            
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
               // *IMPLEMENTE AQUI*
                
                foreach( string veiculo in veiculos)

                {

                    Console.WriteLine(veiculo);

                }

            }

            else

            {

                Console.WriteLine("Não há veículos estacionados.");

            }

        }

    }
    




