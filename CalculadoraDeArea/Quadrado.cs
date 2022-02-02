using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeArea
{
    internal class Quadrado : ICalcularArea
    {
        public int QuadradoLado { get; set; }
        public int QuadradoArea { get; set;}

        public Quadrado()
        {

        }

        public Quadrado(int QuadradoLado)
        {
            this.QuadradoLado = QuadradoLado;
        }      

        public void CalcularArea()
        {          
            QuadradoArea = QuadradoLado * QuadradoLado;
            Console.WriteLine("A área é: {0}", +QuadradoArea);
        }

        public void Exibir()
        {
            Console.WriteLine("Entre com o lado do quadrado: ");
            QuadradoLado = Convert.ToInt32(Console.ReadLine());
            CalcularArea();
        }       
        
    }            
}
