namespace GestaoDeEquipamentos.ConsoleApp.Utilidades;

public static class GeradosIds
{
    private static int contadorIdsEquipamentos = 1;

    private static int contadosIdsChamados = 1;

    public static int ObterIdEquipamento()
    {
        return contadorIdsEquipamentos++;
    }

    public static int ObterIdChamado()
    {
        return contadosIdsChamados++;
    }
}
