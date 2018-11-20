using System;
namespace sistemalocadora
{
    public class Veiculo
    {
        public string marca { get; set; }

        public string modelo { get; set; }

        public int ano { get; set; }

        public virtual void tipoVeiculo()
        {
            Console.WriteLine("Todos os veiculos");
        }
        public Veiculo()
        {
        }
    }
}
