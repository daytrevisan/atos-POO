using System;

namespace AcademiaDotNet;

public class Passaro : Animal {

    public string bico { get; set; }
    public bool voar { get; set; }
    public string tipo { get; set; }

    public Passaro(string nome, int idade, string bico, bool voar, string tipo) : base(nome, idade) {
        this.bico = bico;
        this.voar = voar;
        this.tipo = tipo;
    }

    public override void Som() {
        Console.WriteLine("Canto do pássaro");
    }
    public override string ToString() {
        return $"Pássaro: Nome={nome}, Idade={idade}, Bico={bico}, Voar={voar}, Tipo={tipo}";
    }
}