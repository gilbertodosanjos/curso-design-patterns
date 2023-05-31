
using AulaPatternsCriacaoBuilder.Studios;

namespace AulaPatternsCriacaoBuilder.Builders;

public class Studio24mBuilder : StudioBuilder
{
    public Studio24mBuilder()
    {
        studio = new Studio24m();
    }
    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(180000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("FinaAnastaciaImoveis");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Ceramica");
    }

}
