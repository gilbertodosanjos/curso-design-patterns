
using AulaPatternsCriacaoBuilder.Studios;

namespace AulaPatternsCriacaoBuilder.Builders;

public class Studio28mBuilder : StudioBuilder
{
    public Studio28mBuilder()
    {
        studio = new Studio28m();
    }
    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(22000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("FinanciamentoDiamenteAnastacia");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Porcelanato");
    }
}
