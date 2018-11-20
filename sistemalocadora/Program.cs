using System;

namespace sistemalocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Modelo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Informe o Marca");
            string marca = Console.ReadLine();

            Console.WriteLine("Informe o Ano");
            int  ano = Convert.ToInt32(Console.ReadLine());


           
            Carro carro= new Carro(modelo, marca, ano);
            carro.tipoVeiculo();
            Console.WriteLine("Carro passeio\nModelo: {0}\nMarca: {1}\nAno: {2}\nQuantidade de Portas: ", carro.modelo, carro.marca, carro.ano);





        }
    }
}
