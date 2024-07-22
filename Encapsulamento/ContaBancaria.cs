using System;

namespace AcademiaDotNet;

public class ContaBancaria {

    private double saldo { get; set; }
    public double valor{ get { return saldo; } }

    public ContaBancaria(double saldo) {
        this.saldo = saldo;
    }

    public void Depositar(double valor) {
        saldo += valor;
        Console.WriteLine($"O depósito de R${valor} foi concluído com sucesso! Seu saldo atual é de R${saldo}.");
    }

    public void Sacar(double valor) {

        if(saldo > 0 && valor < saldo) {
            saldo -= valor;
            Console.WriteLine($"O saque de R${valor} foi efetuado com sucesso! Seu saldo atual é de R${saldo}.");

        } else {
            Console.WriteLine("Saldo insuficiente para saque. Escolha outra opção.");
        }
    }

}