namespace Cadastro_Venda_Veiculos.Models
{
    public class CarroViewModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int? Kilometragem { get; set; }
        public double Valor { get; set; }
    }
}
