using System;

namespace AcademiaDotNet;

public abstract class Animal {

    protected string nome { get; set; }
    protected int idade { get; set; }

    public Animal(string nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }

    public abstract void Som();

}