using System;

namespace Exercicio01
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Slado { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor){
            Slado += valor;
        }
         public void Saque(double valor){
            Slado -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
            +Numero
            +", Titular: "
            +Nome
            +", Slado: $ "
            +Slado.ToString("F2");
        }

    }
}