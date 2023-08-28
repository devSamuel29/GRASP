namespace GRASP.Classes;

public static class DiarioAlimentacao
{
    private static readonly List<RegistroAlimentacao> registros = new();

    public static void RegistrarAlimentacao(Dieta dieta)
    {
        RegistroAlimentacao registro = new RegistroAlimentacao
        {
            Dieta = dieta,
            DataAlimentacao = DateTime.Now,
        };

        registros.Add(registro);
    }

    public static void Mostrar()
    {
        registros.ForEach(
            registro =>
                Console.WriteLine(
                    $"Animal: {registro.Dieta.Animal.Nome}, Idade: {registro.Dieta.Animal.Idade}, Tipo do alimento: {registro.Dieta.TipoAlimento}, Quantidade: {registro.Dieta.Quantidade} e Data alimentada: {registro.DataAlimentacao}"
                )
        );
    }
}
