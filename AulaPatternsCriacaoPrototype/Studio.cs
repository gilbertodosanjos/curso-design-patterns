namespace AulaPatternsCriacaoPrototype;

public class Studio : StudioModel
{
    private string _tipoStudio;
    private string _tipoFinanciamento;
    private decimal _valorStudio;

    public Studio(string tipoStudio, string tipoFinanciamento, decimal valorStudio)
    {
        _tipoStudio = tipoStudio;
        _tipoFinanciamento = tipoFinanciamento;
        _valorStudio = valorStudio;
    }

    public override StudioModel clone()
    {
        System.Console.WriteLine(new string('-',40));
        System.Console.WriteLine($"Studio clonado:{tipoStudio}\nFinanciamento:{_tipoFinanciamento}\nValor:{_valorStudio}\n");
        return this.MemberwiseClone() as StudioModel;
    }
}
