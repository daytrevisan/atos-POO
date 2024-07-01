using System;

namespace AcademiaDotNet;

public class Cachorro : Animal {

    public string raca { get; set; }
    public string pelagem { get; set; }

    public Cachorro(string nome, int idade, string raca, string pelagem) : base(nome, idade){
        this.raca = raca;
        this.pelagem = pelagem;
    }

    public override void Som() {
        Console.WriteLine("Au-Au");
    }

    public override string ToString() {
        return $"Cachorro: Nome={nome}, Idade={idade}, Raça={raca}, Pelagem={pelagem}";
    }
}