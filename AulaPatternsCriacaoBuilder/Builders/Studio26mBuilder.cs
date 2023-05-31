
using AulaPatternsCriacaoBuilder.Studios;

namespace AulaPatternsCriacaoBuilder.Builders;

public class Studio26mBuilder : StudioBuilder
{
    public Studio26mBuilder()
    {
        studio = new Studio26m();
    }
    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(190000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("FinanciamentoInestFaciaAnastacia");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Madeira");
    }
}
