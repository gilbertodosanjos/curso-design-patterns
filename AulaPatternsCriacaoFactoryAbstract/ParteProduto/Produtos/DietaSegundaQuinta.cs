using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class DietaSegundaQuinta : IDieta
{
    public DietaSegundaQuinta()
    {
        this.obterAlimentacao();
    }
    
    public void obterAlimentacao()
    {
       System.Console.WriteLine("Dieta segunda e quinta feira");
    }
}
