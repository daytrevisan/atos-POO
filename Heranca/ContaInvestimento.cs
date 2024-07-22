using System;

namespace AcademiaDotNet {
    public class ContaInvestimento : ContaBancaria {

        public ContaInvestimento() : base(saldo, valor) {}

        public override void Depositar(double valor) {

            if(valor > 0) {
                this.saldo += valor;
                Console.WriteLine($"O depósito de R${valor} foi efetuado com sucesso! Seu saldo na Conta Investimento é de R${saldo}.");

            } else {
                Console.WriteLine("O valor deve ser positivo.");
            }
        }

        public override void Sacar(double valor) {

            if(valor > 0) {

                if (valor <= saldo) {
                    saldo -= valor;
                    Console.WriteLine($"O saque de R${valor} foi efetuado com sucesso! Seu saldo na Conta Investimento é de {saldo}.");
                
                } else {
                    Console.WriteLine("Saldo insuficiente");
                }
            } else {
                Console.WriteLine("Valor de saque deve ser positivo.");
            }

        }
    }
}