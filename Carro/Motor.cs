﻿using System;

namespace Carro
{
    public class Motor
    {
        private double cilindrada;
        private Carro carro;
        public double Cilindrada { get { return cilindrada; } }

        public Motor(double cilindrada)
        {
            if (cilindrada <= 0.0)
                throw new Exception("Cilindrada informada é inválida.");

            this.cilindrada = cilindrada;
        }

        public void AdicionarCarro(Carro carro)
        {
            if (carro == null)
                throw new Exception("O carro não pode ser nulo.");

            if (this.carro != null)
                throw new Exception("O motor já está em um carro");

            this.carro = carro;
        }
    }
}
