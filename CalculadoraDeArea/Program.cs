namespace CalculadoraDeArea 


{
    internal class Program
    {

        public enum Calculos
        {
            Vazio, //0
            Quadrado, //1
            Triangulo, //2
            Circulo,  //3
        }
        static void Main(string[] args)
        {
            int escolha = 0;

            Console.WriteLine("Escolha de qual polígono quer calcular a área: ");
            Console.WriteLine("Quadrado 1, Triângulo 2 e Círculo 3 ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1: Quadrado quadrado = new Quadrado();
                    quadrado.Exibir();
                    break;

                case 2: Triangulo triangulo = new Triangulo();
                    triangulo.Exibir(); 
                    break;

                case 3:
                    Console.WriteLine(Calculos.Circulo);
                    break;
            }
            
        }
    }
}
