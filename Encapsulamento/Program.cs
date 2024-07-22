/*
Crie uma classe ContaBancaria com atributos como Saldo e métodos para Depositar e Sacar.
Encapsule o saldo para que só possa ser acessado por meio dos métodos públicos.
*/

using System;

namespace AcademiaDotNet;

public class Program {
    public static void Main(string[] args) {
        
        ContaBancaria conta = new ContaBancaria(0.0);

        conta.Depositar(200);
        conta.Sacar(80);

    }
}