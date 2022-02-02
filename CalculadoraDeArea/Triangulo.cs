using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeArea
{
    internal class Triangulo : ICalcularArea
    {
        public int TrianguloAltura { get; set; }
        public int TrianguloBase { get; set; }
        public int TrianguloArea { get; set; }
        
        public Triangulo()
        {

        }
        
        public Triangulo (int TrianguloAltura, int TrianguloBase)
        {
            this.TrianguloAltura = TrianguloAltura;
            this.TrianguloBase = TrianguloBase;
        }

        public void CalcularArea()
        {
            TrianguloArea = (TrianguloAltura * TrianguloBase) / 2;            
            Console.WriteLine("A área é: {0}", + TrianguloArea);
        }

        public void Exibir()
        {  
            Console.WriteLine("Entre com a altura do triangulo: ");
            TrianguloAltura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a base do triangulo: ");
            TrianguloBase = Convert.ToInt32(Console.ReadLine());
            CalcularArea();
        }
    }

    
}
