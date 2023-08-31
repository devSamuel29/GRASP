namespace GRASP.Classes;

public class Dieta
{
    public required string TipoAlimento { get; set; }

    public required int Quantidade { get; set; }

    public void Mostrar()
    {
        Console.WriteLine(
            $"Tipo do alimento: {TipoAlimento}, Quantidade: {Quantidade}"
        );
    }
}
