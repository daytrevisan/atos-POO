/*
Crie uma classe Animal com atributos como Nome, Idade e Som. Abstraia os conceitos comuns a todos os animais.
Em seguida, crie subclasses como Cachorro, Gato e Pássaro, adicionando comportamentos específicos para cada tipo de animal.
*/

using System;

namespace AcademiaDotNet;

public class Program {

    public static void Main(string[] args) {

        Cachorro cachorro = new Cachorro("Bobby", 3, "labrador", "amarela");
        Passaro passaro = new Passaro("Tweety", 1, "pontudo", true, "calopsita");

        Console.WriteLine(cachorro);
        Console.WriteLine(passaro);

    }


}
