using System;

namespace Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(1.0);
            Carro chevet = new Carro("1234", "conversivel", motor1);
            Console.WriteLine("Velocidade do Chevet é: " + chevet.CalcularVelocidade() + "km/h");
        }
    }
}
