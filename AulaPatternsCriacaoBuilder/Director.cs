using AulaPatternsCriacaoBuilder.Builders;

namespace AulaPatternsCriacaoBuilder;

public class Director
{
    public void CosntruirStudio(StudioBuilder studioBuilder)
    {
        studioBuilder.EscolherPiso();
        studioBuilder.DefinirValorStudio();
        studioBuilder.EscolherFinanciamento();
    }
}
