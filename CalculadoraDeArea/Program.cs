namespace CalculadoraDeArea 


{
    internal class Program
    {

        public enum Calculos
        {
            Vazio, //0 Para a escolha do quadrado ser 1 não 0
            Quadrado, //1
            Triangulo, //2
            Circulo,  //3
            Retangulo, //4
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha de qual polígono quer calcular a área: ");
            Console.WriteLine("Quadrado 1, Triângulo 2, Círculo 3 e Retângulo 4: ");
            Calculos escolha = (Calculos)Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case Calculos.Quadrado: Quadrado quadrado = new();
                    quadrado.Exibir();
                    break;

                case Calculos.Triangulo: Triangulo triangulo = new();
                    triangulo.Exibir(); 
                    break;

                case Calculos.Circulo: Circulo circulo = new();
                    circulo.Exibir();
                    break;

                case Calculos.Retangulo: Retangulo retangulo = new();
                    retangulo.Exibir();
                    break;
            }
            
        }
    }
}
