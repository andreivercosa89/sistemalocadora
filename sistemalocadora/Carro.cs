using System;
namespace sistemalocadora
{
    public class Carro : Veiculo
    {
        public Carro(string modelo, string marca, int ano){
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
        }
        public override void tipoVeiculo()
        {
            Console.WriteLine("Carro");
        }

        public Carro()
        {
        }
    }
}
