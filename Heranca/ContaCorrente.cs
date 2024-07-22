using System;

namespace AcademiaDotNet
{
    public class ContaCorrente : ContaBancaria {

        public ContaCorrente() : base(saldo, valor) {}

        public override void Depositar(double valor) {
            base.Depositar(valor);
        }

        public override void Sacar(double valor) {
            base.Sacar(valor);
        }

    }
}