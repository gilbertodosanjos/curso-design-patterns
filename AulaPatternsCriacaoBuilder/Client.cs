using AulaPatternsCriacaoBuilder.Builders;
using AulaPatternsCriacaoBuilder.Studios;

namespace AulaPatternsCriacaoBuilder;

public class Client
{
    public void ConsumirDados()
    {
        Director director = new Director();
        StudioBuilder studioBuilder;
        Studio studio;

        studioBuilder =  new Studio24mBuilder();
        director.CosntruirStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        ImprimirResultado(studio,"24m");

        studioBuilder =  new Studio26mBuilder();
        director.CosntruirStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        ImprimirResultado(studio,"26m");


    }

    private void ImprimirResultado(Studio studio, string imovel)
    {
        System.Console.WriteLine(new string('-',40));
        System.Console.WriteLine($"[+] - studio {imovel}");
        System.Console.WriteLine("Valor: {0}\nPiso: {1}\nFinanciamento:{2}",
            studio.ValorStudio.ToString("C"),
            studio.TipoPiso,
            studio.TipoFinanciamento

        );
    }
}
