using GRASP.Classes;

Animal animal = new() { Nome = "Leão", Idade = 3 };

Dieta dieta =
    new()
    {
        Animal = animal,
        TipoAlimento = "Carne",
        Quantidade = 3
    };

DiarioAlimentacao.RegistrarAlimentacao(animal, dieta);
DiarioAlimentacao.Mostrar();
