using System;

namespace AcademiaDotNet
{
    public class ContaPoupanca : ContaBancaria {

        public ContaPoupanca() : base(saldo, valor) {}

        public override void Depositar(double valor) {

            if(valor > 0) {
                this.saldo += valor;
                Console.WriteLine($"O depósito de {valor} foi efetuado com sucesso! Seu saldo na Conta Poupança é de {saldo}.");

            } else {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }
        public override void Sacar(double valor) {

            if(valor > 0) {

                if (valor <= saldo) {
                    this.saldo -= valor;
                    Console.WriteLine($"O saque de R${valor} foi efetuado com sucesso! Seu saldo na Conta Poupança é de {saldo}");
                
                } else {
                    Console.WriteLine("Saldo insuficiente");
                }
            } else {
                Console.WriteLine("Valor de saque deve ser positivo.");
            }

        }
    }
}