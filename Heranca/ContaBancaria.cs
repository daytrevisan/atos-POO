using System;

namespace AcademiaDotNet
{
    public class ContaBancaria {
        protected double saldo {get; set;}
        public double valor {get; set;}

        public ContaBancaria(double saldo, double valor) {
            this.saldo = saldo;
            this.valor = valor;
        }

        public virtual void Depositar(double valor) {

            if(valor > 0) {
                this.saldo += valor;
                Console.WriteLine($"O depósito de {valor} foi efetuado com sucesso! Seu saldo é de {saldo}");

            } else {
                Console.WriteLine("O valor de depósito deve ser positivo");
            }
        }

        public virtual void Sacar(double valor) {

            if(valor > 0) {
                
                if(valor <= saldo) {
                    this.saldo -= valor;
                    Console.WriteLine($"O saque de {valor} foi efetuado com sucesso! Seu saldo é de {saldo}");
                
                } else {
                    Console.WriteLine("Saldo insuficiente.");
                }
            
            } else {
                Console.WriteLine("Valor de saque deve ser positivo.");
            }

        }
    }
}