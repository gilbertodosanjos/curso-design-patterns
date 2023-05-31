using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class TreinoSegundaQuinta : ITreino
{
    public TreinoSegundaQuinta()
    {
        this.obterTreino();
    }
    
    public void obterTreino()
    {
        System.Console.WriteLine("Treino segunda e quinta feira. . .");
    }
}
