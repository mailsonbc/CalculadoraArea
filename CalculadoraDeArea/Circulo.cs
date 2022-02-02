namespace CalculadoraDeArea
{
    internal class Circulo : ICalcularArea
    {
        public int CirculoRaio { get; set; }
        public int CirculoPi { get; set; }
        public double CirculoArea { get; set; }

        public Circulo()
        {

        }

        public Circulo(int CirculoRaio)
        {
            this.CirculoRaio = CirculoRaio;
        }

        public void CalcularArea()
        {
            CirculoArea = Math.PI * (Math.Pow(CirculoRaio, 2));
            Console.WriteLine("A área é: {0}", +CirculoArea);
        }

        public void Exibir()
        {
            Console.WriteLine("Entre com o raio do círculo: ");
            CirculoRaio = Convert.ToInt32(Console.ReadLine());
            CalcularArea();
        }
    }
}
