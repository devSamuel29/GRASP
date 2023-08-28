namespace GRASP.Classes;

public class RegistroAlimentacao
{
    public required Animal Animal { get; set; }

    public required Dieta Dieta { get; set; }

    public required DateTime DataAlimentacao { get; set; }
}
