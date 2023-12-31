namespace DesafioEstacionamento.Models
{
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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();
        
            if (placa != null)
            {
                // Converte a placa para maiúsculas antes de adicionar à lista
                placa = placa.ToUpper();
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("A placa do veículo é nula. Não foi possível adicionar à lista.");
            }
        }

        public void RemoverVeiculo()
        {
            
             Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();

            if (placa != null && veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // Remove a placa digitada da lista de veículos (comparação de cultura invariável)
                    veiculos.RemoveAll(x => string.Equals(x, placa, StringComparison.InvariantCultureIgnoreCase));

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Certifique-se de inserir um valor numérico.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
             if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
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
}
