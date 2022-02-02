using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeArea
{
    internal class Retangulo : ICalcularArea
    {
        public int RetanguloBase { get; set; }  
        public int RetanguloAltura { get; set; }
        public int RetanguloArea { get; set; }

        public Retangulo()
        {

        }

        public Retangulo(int RetanguloBase, int RetanguloAltura)
        {
            this.RetanguloBase = RetanguloBase;
            this.RetanguloAltura = RetanguloAltura;
        }

        public void CalcularArea()
        {
            RetanguloArea = (RetanguloAltura * RetanguloBase);
            Console.WriteLine("A área é: {0}", +RetanguloArea);
        }

        public void Exibir()
        {
            Console.WriteLine("Entre com a base do retângulo: ");
            RetanguloBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a altura do retângulo: ");
            RetanguloAltura = Convert.ToInt32(Console.ReadLine());
            CalcularArea();
        }

    }
}
