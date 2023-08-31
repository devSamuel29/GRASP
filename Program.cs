using GRASP.Classes;

Dieta dieta =
    new()
    {
        TipoAlimento = "Carne",
        Quantidade = 3
    };

Animal animal = new() { Nome = "Leão", Dieta = dieta };

DiarioAlimentacao.RegistrarAlimentacao(animal);
