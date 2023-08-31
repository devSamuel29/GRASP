namespace GRASP.Classes;

public static class DiarioAlimentacao
{
    private static readonly List<RegistroAlimentacao> registros = new();

    public static void RegistrarAlimentacao(Animal animal)
    {
        RegistroAlimentacao registro = new RegistroAlimentacao
        {
            Animal = animal,
            DataAlimentacao = DateTime.Now,
        };

        registros.Add(registro);
    }
}
