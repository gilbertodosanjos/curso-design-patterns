using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class DietaQuartaSabado : IDieta
{
    public DietaQuartaSabado()
    {
        this.obterAlimentacao();
    }
    
    public void obterAlimentacao()
    {
     System.Console.WriteLine("Dieta de segunda e quinta feira");
    }
}
