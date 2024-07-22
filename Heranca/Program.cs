/*
Estenda o exemplo da ContaBancaria criando subclasses como ContaPoupanca, ContaCorrente e ContaInvestimento.
Cada uma dessas classes deve herdar os métodos e atributos da classe base ContaBancaria.
*/

using System;

namespace AcademiaDotNet;
public class Program {
    public static void Main(string[] args) {

        ContaCorrente contaCorrente = new ContaCorrente();
        ContaPoupanca contaPoupanca = new ContaPoupanca();
        ContaInvestimento contaInvestimento = new ContaInvestimento();

        contaCorrente.Depositar(200);
        contaCorrente.Sacar(50);

        contaPoupanca.Depositar(500);
        contaPoupanca.Sacar(20);

        contaInvestimento.Depositar(1000);
        contaInvestimento.Sacar(10);

    }
}